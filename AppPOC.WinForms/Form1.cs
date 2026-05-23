using Krypton.Toolkit;
using Microsoft.Win32;
using System.Text;

namespace AppPOC.WinForms;

public partial class Form1 : KryptonForm
{
    private Color _tabHeaderBackground;
    private Color _tabHeaderSelected;
    private Color _tabHeaderBorder;
    private Color _tabHeaderText;
    private Point _searchButtonOriginalLocation;
    private bool _isSearchButtonPressed;

    public Form1()
    {
        InitializeComponent();

        tabMain.Appearance = TabAppearance.Normal;
        tabMain.DrawMode = TabDrawMode.OwnerDrawFixed;
        tabMain.SizeMode = TabSizeMode.Fixed;
        tabMain.ItemSize = new Size(120, 34);
        tabMain.Padding = new Point(14, 4);
        tabMain.DrawItem += TabMain_DrawItem;

        ApplyAdaptiveTheme();

        txtNumerPolisy.KeyPress += TxtNumerPolisy_KeyPress;
        txtNumerPolisy.TextChanged += TxtNumerPolisy_TextChanged;
        chkPolisa.CheckedChanged += ChkPolisa_CheckedChanged;
        chkOferta.CheckedChanged += ChkOferta_CheckedChanged;
        btnAkcja.Click += BtnAkcja_Click;
        btnAkcja.MouseDown += BtnAkcja_MouseDown;
        btnAkcja.MouseUp += BtnAkcja_MouseUp;
        btnAkcja.MouseLeave += BtnAkcja_MouseLeave;

        _searchButtonOriginalLocation = btnAkcja.Location;
    }

    private async void BtnAkcja_Click(object? sender, EventArgs e)
    {
        await Task.CompletedTask;
    }

    private void BtnAkcja_MouseDown(object? sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Left || _isSearchButtonPressed)
        {
            return;
        }

        _searchButtonOriginalLocation = btnAkcja.Location;
        btnAkcja.Location = new Point(_searchButtonOriginalLocation.X, _searchButtonOriginalLocation.Y + 1);
        _isSearchButtonPressed = true;
    }

    private void BtnAkcja_MouseUp(object? sender, MouseEventArgs e)
    {
        RestoreSearchButtonPosition();
    }

    private void BtnAkcja_MouseLeave(object? sender, EventArgs e)
    {
        if (Control.MouseButtons == MouseButtons.Left)
        {
            return;
        }

        RestoreSearchButtonPosition();
    }

    private void RestoreSearchButtonPosition()
    {
        if (!_isSearchButtonPressed)
        {
            return;
        }

        btnAkcja.Location = _searchButtonOriginalLocation;
        _isSearchButtonPressed = false;
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
        _tabHeaderBackground = isDark ? Color.FromArgb(60, 61, 65) : Color.FromArgb(226, 232, 240);
        _tabHeaderSelected = appBackground;
        _tabHeaderBorder = isDark ? Color.FromArgb(95, 99, 104) : Color.FromArgb(203, 213, 225);
        _tabHeaderText = isDark ? Color.FromArgb(232, 234, 237) : Color.FromArgb(30, 41, 59);

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
        lblOpcjeInfo.StateCommon.ShortText.Color1 = labelColor;

        tabSearch.BackColor = appBackground;
        tabOpcje.BackColor = appBackground;
        tabMain.BackColor = appBackground;

        chkPolisa.StateCommon.ShortText.Color1 = labelColor;
        chkOferta.StateCommon.ShortText.Color1 = labelColor;
        chkStylClassic.StateCommon.ShortText.Color1 = labelColor;
        chkStylAccent.StateCommon.ShortText.Color1 = isDark ? Color.FromArgb(138, 180, 248) : Color.FromArgb(14, 116, 144);
        chkStylSoft.StateCommon.ShortText.Color1 = isDark ? Color.FromArgb(154, 160, 166) : Color.FromArgb(100, 116, 139);

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

        tabMain.Invalidate();
    }

    private void TabMain_DrawItem(object? sender, DrawItemEventArgs e)
    {
        if (e.Index < 0)
        {
            return;
        }

        var isSelected = e.Index == tabMain.SelectedIndex;
        var baseRect = tabMain.GetTabRect(e.Index);
        var tabRect = isSelected
            ? new Rectangle(baseRect.X, baseRect.Y - 2, baseRect.Width, baseRect.Height + 2)
            : new Rectangle(baseRect.X, baseRect.Y + 2, baseRect.Width, baseRect.Height - 2);

        using var backgroundBrush = new SolidBrush(isSelected ? _tabHeaderSelected : _tabHeaderBackground);
        using var borderPen = new Pen(_tabHeaderBorder);
        using var textBrush = new SolidBrush(_tabHeaderText);

        e.Graphics.FillRectangle(backgroundBrush, tabRect);
        if (!isSelected)
        {
            e.Graphics.DrawRectangle(borderPen, tabRect);
        }
        else
        {
            using var mergePen = new Pen(_tabHeaderSelected);
            e.Graphics.DrawLine(mergePen, tabRect.Left + 1, tabRect.Bottom, tabRect.Right - 1, tabRect.Bottom);
        }

        var text = tabMain.TabPages[e.Index].Text;
        var flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
        TextRenderer.DrawText(e.Graphics, text, new Font("Segoe UI Semibold", 10F, FontStyle.Bold), tabRect, textBrush.Color, flags);
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
