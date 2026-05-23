using Krypton.Toolkit;
using Microsoft.Win32;
using System.Text;

namespace AppPOC.WinForms;

public partial class Form1 : KryptonForm
{
    private bool _isSearchButtonAnimating;

    public Form1()
    {
        InitializeComponent();

        ApplyAdaptiveTheme();

        txtNumerPolisy.KeyPress += TxtNumerPolisy_KeyPress;
        txtNumerPolisy.TextChanged += TxtNumerPolisy_TextChanged;
        chkPolisa.CheckedChanged += ChkPolisa_CheckedChanged;
        chkOferta.CheckedChanged += ChkOferta_CheckedChanged;
        btnAkcja.Click += BtnAkcja_Click;
    }

    private async void BtnAkcja_Click(object? sender, EventArgs e)
    {
        if (_isSearchButtonAnimating)
        {
            return;
        }

        _isSearchButtonAnimating = true;

        var originalBounds = btnAkcja.Bounds;
        var pressedBounds = new Rectangle(
            originalBounds.X + 2,
            originalBounds.Y + 1,
            originalBounds.Width - 4,
            originalBounds.Height - 2);

        try
        {
            btnAkcja.Bounds = pressedBounds;
            await Task.Delay(50);
            btnAkcja.Bounds = originalBounds;
            await Task.Delay(40);
        }
        finally
        {
            btnAkcja.Bounds = originalBounds;
            _isSearchButtonAnimating = false;
        }
    }

    private void ApplyAdaptiveTheme()
    {
        var isDark = IsDarkModeEnabled();

        var appBackground = isDark ? Color.FromArgb(32, 33, 36) : SystemColors.Control;
        var titleColor = isDark ? Color.FromArgb(232, 234, 237) : Color.FromArgb(15, 23, 42);
        var subtitleColor = isDark ? Color.FromArgb(189, 193, 198) : Color.FromArgb(71, 85, 105);
        var labelColor = isDark ? Color.FromArgb(232, 234, 237) : Color.FromArgb(30, 41, 59);
        var inputBackground = isDark ? Color.FromArgb(48, 49, 52) : Color.White;
        var inputBorder = isDark ? Color.FromArgb(95, 99, 104) : Color.FromArgb(203, 213, 225);
        var inputText = isDark ? Color.FromArgb(232, 234, 237) : Color.FromArgb(15, 23, 42);

        BackColor = appBackground;

        if (StateCommon is not null)
        {
            StateCommon.Back.Color1 = appBackground;
            StateCommon.Back.Color2 = appBackground;
            StateCommon.Border.DrawBorders = PaletteDrawBorders.None;
            StateCommon.Border.Width = 0;
        }

        lblTitle.StateCommon.ShortText.Color1 = titleColor;
        lblSubtitle.StateCommon.ShortText.Color1 = subtitleColor;
        lblNumerPolisy.StateCommon.ShortText.Color1 = labelColor;

        chkPolisa.StateCommon.ShortText.Color1 = labelColor;
        chkOferta.StateCommon.ShortText.Color1 = labelColor;

        txtNumerPolisy.StateCommon.Back.Color1 = inputBackground;
        txtNumerPolisy.StateCommon.Border.Color1 = inputBorder;
        txtNumerPolisy.StateCommon.Border.Color2 = inputBorder;
        txtNumerPolisy.StateCommon.Content.Color1 = inputText;
        txtNumerPolisy.StateActive.Back.Color1 = inputBackground;
        txtNumerPolisy.StateActive.Border.Color1 = isDark ? Color.FromArgb(138, 180, 248) : Color.FromArgb(14, 116, 144);
        txtNumerPolisy.StateActive.Border.Color2 = isDark ? Color.FromArgb(138, 180, 248) : Color.FromArgb(14, 116, 144);

        var buttonNormal = isDark ? Color.FromArgb(138, 180, 248) : Color.FromArgb(14, 116, 144);
        var buttonHover = isDark ? Color.FromArgb(123, 170, 247) : Color.FromArgb(6, 95, 120);
        var buttonPressed = isDark ? Color.FromArgb(103, 156, 241) : Color.FromArgb(12, 74, 95);
        var buttonText = isDark ? Color.FromArgb(32, 33, 36) : Color.White;

        btnAkcja.StateCommon.Back.Color1 = buttonNormal;
        btnAkcja.StateCommon.Back.Color2 = buttonNormal;
        btnAkcja.StateCommon.Border.Color1 = buttonNormal;
        btnAkcja.StateCommon.Border.Color2 = buttonNormal;
        btnAkcja.StateCommon.Content.ShortText.Color1 = buttonText;

        btnAkcja.OverrideDefault.Back.Color1 = buttonNormal;
        btnAkcja.OverrideDefault.Back.Color2 = buttonNormal;
        btnAkcja.OverrideDefault.Border.Color1 = buttonNormal;
        btnAkcja.OverrideDefault.Border.Color2 = buttonNormal;

        btnAkcja.StateTracking.Back.Color1 = buttonHover;
        btnAkcja.StateTracking.Back.Color2 = buttonHover;
        btnAkcja.StateTracking.Border.Color1 = buttonHover;
        btnAkcja.StateTracking.Border.Color2 = buttonHover;

        btnAkcja.StatePressed.Back.Color1 = buttonPressed;
        btnAkcja.StatePressed.Back.Color2 = buttonPressed;
        btnAkcja.StatePressed.Border.Color1 = buttonPressed;
        btnAkcja.StatePressed.Border.Color2 = buttonPressed;

        btnAkcja.OverrideFocus.Back.Color1 = buttonHover;
        btnAkcja.OverrideFocus.Back.Color2 = buttonHover;
        btnAkcja.OverrideFocus.Border.Color1 = buttonHover;
        btnAkcja.OverrideFocus.Border.Color2 = buttonHover;
    }

    private static bool IsDarkModeEnabled()
    {
        const string personalizePath = @"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize";
        const string valueName = "AppsUseLightTheme";

        try
        {
            using var key = Registry.CurrentUser.OpenSubKey(personalizePath);
            var value = key?.GetValue(valueName);
            if (value is int intValue)
            {
                return intValue == 0;
            }
        }
        catch
        {
            // Fallback to light theme if the registry key is unavailable.
        }

        return false;
    }

    private void ChkPolisa_CheckedChanged(object? sender, EventArgs e)
    {
        if (chkPolisa.Checked)
        {
            chkOferta.Checked = false;
        }
    }

    private void ChkOferta_CheckedChanged(object? sender, EventArgs e)
    {
        if (chkOferta.Checked)
        {
            chkPolisa.Checked = false;
        }
    }

    private static void TxtNumerPolisy_KeyPress(object? sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    private static void TxtNumerPolisy_TextChanged(object? sender, EventArgs e)
    {
        if (sender is not KryptonTextBox textBox)
        {
            return;
        }

        var original = textBox.Text;
        if (string.IsNullOrEmpty(original))
        {
            return;
        }

        var filtered = new StringBuilder(original.Length);
        foreach (var ch in original)
        {
            if (char.IsDigit(ch))
            {
                filtered.Append(ch);
            }
        }

        if (filtered.Length == original.Length)
        {
            return;
        }

        var selection = textBox.SelectionStart;
        textBox.Text = filtered.ToString();
        textBox.SelectionStart = Math.Min(selection, textBox.Text.Length);
    }
}
