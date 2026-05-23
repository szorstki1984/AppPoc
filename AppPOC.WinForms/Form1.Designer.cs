using Krypton.Toolkit;

namespace AppPOC.WinForms;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.lblTitle = new KryptonLabel();
        this.lblSubtitle = new KryptonLabel();
        this.lblNumerPolisy = new KryptonLabel();
        this.txtNumerPolisy = new KryptonTextBox();
        this.chkPolisa = new KryptonCheckBox();
        this.chkOferta = new KryptonCheckBox();
        this.btnAkcja = new KryptonButton();
        this.SuspendLayout();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(620, 390);
        this.Controls.Add(this.btnAkcja);
        this.Controls.Add(this.chkOferta);
        this.Controls.Add(this.chkPolisa);
        this.Controls.Add(this.txtNumerPolisy);
        this.Controls.Add(this.lblNumerPolisy);
        this.Controls.Add(this.lblSubtitle);
        this.Controls.Add(this.lblTitle);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.MinimumSize = new System.Drawing.Size(636, 429);
        this.Name = "Form1";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Wyszukiwanie dokumentów";

        // lblTitle
        this.lblTitle.Location = new System.Drawing.Point(36, 22);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(232, 38);
        this.lblTitle.TabIndex = 6;
        this.lblTitle.Values.Text = "Szukaj dokumentu";
        this.lblTitle.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(15, 23, 42);
        this.lblTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);

        // lblSubtitle
        this.lblSubtitle.Location = new System.Drawing.Point(38, 58);
        this.lblSubtitle.Name = "lblSubtitle";
        this.lblSubtitle.Size = new System.Drawing.Size(343, 24);
        this.lblSubtitle.TabIndex = 5;
        this.lblSubtitle.Values.Text = "Wprowadź numer polisy i wybierz typ dokumentu";
        this.lblSubtitle.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblSubtitle.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.5F);

        // lblNumerPolisy
        this.lblNumerPolisy.Location = new System.Drawing.Point(40, 112);
        this.lblNumerPolisy.Name = "lblNumerPolisy";
        this.lblNumerPolisy.Size = new System.Drawing.Size(129, 25);
        this.lblNumerPolisy.TabIndex = 4;
        this.lblNumerPolisy.Values.Text = "Numer polisy:";
        this.lblNumerPolisy.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
        this.lblNumerPolisy.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);

        // txtNumerPolisy
        this.txtNumerPolisy.Location = new System.Drawing.Point(40, 140);
        this.txtNumerPolisy.Name = "txtNumerPolisy";
        this.txtNumerPolisy.Size = new System.Drawing.Size(540, 44);
        this.txtNumerPolisy.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(255, 255, 255);
        this.txtNumerPolisy.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(203, 213, 225);
        this.txtNumerPolisy.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(203, 213, 225);
        this.txtNumerPolisy.StateCommon.Border.ColorStyle = PaletteColorStyle.Solid;
        this.txtNumerPolisy.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
        this.txtNumerPolisy.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
        this.txtNumerPolisy.StateCommon.Border.Rounding = 12;
        this.txtNumerPolisy.StateCommon.Border.Width = 1;
        this.txtNumerPolisy.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(15, 23, 42);
        this.txtNumerPolisy.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F);
        this.txtNumerPolisy.TabIndex = 0;
        this.txtNumerPolisy.Text = "";

        // chkPolisa
        this.chkPolisa.AutoSize = false;
        this.chkPolisa.Location = new System.Drawing.Point(40, 214);
        this.chkPolisa.Name = "chkPolisa";
        this.chkPolisa.Size = new System.Drawing.Size(150, 44);
        this.chkPolisa.TabIndex = 1;
        this.chkPolisa.Text = "Polisa";
        this.chkPolisa.Values.Text = "Polisa";
        this.chkPolisa.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
        this.chkPolisa.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);

        // chkOferta
        this.chkOferta.AutoSize = false;
        this.chkOferta.Location = new System.Drawing.Point(180, 214);
        this.chkOferta.Name = "chkOferta";
        this.chkOferta.Size = new System.Drawing.Size(150, 44);
        this.chkOferta.TabIndex = 2;
        this.chkOferta.Text = "Oferta";
        this.chkOferta.Values.Text = "Oferta";
        this.chkOferta.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
        this.chkOferta.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);

        // btnAkcja
        this.btnAkcja.Location = new System.Drawing.Point(40, 286);
        this.btnAkcja.Name = "btnAkcja";
        this.btnAkcja.Size = new System.Drawing.Size(540, 48);
        this.btnAkcja.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(14, 116, 144);
        this.btnAkcja.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(8, 145, 178);
        this.btnAkcja.StateCommon.Back.ColorStyle = PaletteColorStyle.Solid;
        this.btnAkcja.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(14, 116, 144);
        this.btnAkcja.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(8, 145, 178);
        this.btnAkcja.StateCommon.Border.ColorStyle = PaletteColorStyle.Solid;
        this.btnAkcja.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
        this.btnAkcja.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
        this.btnAkcja.StateCommon.Border.Rounding = 12;
        this.btnAkcja.StateCommon.Border.Width = 1;
        this.btnAkcja.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
        this.btnAkcja.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
        this.btnAkcja.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(14, 116, 144);
        this.btnAkcja.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(14, 116, 144);
        this.btnAkcja.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Solid;
        this.btnAkcja.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(14, 116, 144);
        this.btnAkcja.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(14, 116, 144);
        this.btnAkcja.OverrideDefault.Border.ColorStyle = PaletteColorStyle.Solid;
        this.btnAkcja.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.All;
        this.btnAkcja.OverrideDefault.Border.Rounding = 12;
        this.btnAkcja.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(6, 95, 120);
        this.btnAkcja.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(6, 95, 120);
        this.btnAkcja.StateTracking.Back.ColorStyle = PaletteColorStyle.Solid;
        this.btnAkcja.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(6, 95, 120);
        this.btnAkcja.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(6, 95, 120);
        this.btnAkcja.StateTracking.Border.ColorStyle = PaletteColorStyle.Solid;
        this.btnAkcja.StateTracking.Border.DrawBorders = PaletteDrawBorders.All;
        this.btnAkcja.StateTracking.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
        this.btnAkcja.StateTracking.Border.Rounding = 12;
        this.btnAkcja.StateTracking.Border.Width = 1;
        this.btnAkcja.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(12, 74, 95);
        this.btnAkcja.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(12, 74, 95);
        this.btnAkcja.StatePressed.Back.ColorStyle = PaletteColorStyle.Solid;
        this.btnAkcja.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(12, 74, 95);
        this.btnAkcja.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(12, 74, 95);
        this.btnAkcja.StatePressed.Border.ColorStyle = PaletteColorStyle.Solid;
        this.btnAkcja.StatePressed.Border.DrawBorders = PaletteDrawBorders.All;
        this.btnAkcja.StatePressed.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
        this.btnAkcja.StatePressed.Border.Rounding = 12;
        this.btnAkcja.StatePressed.Border.Width = 1;
        this.btnAkcja.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(6, 95, 120);
        this.btnAkcja.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(6, 95, 120);
        this.btnAkcja.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Solid;
        this.btnAkcja.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(6, 95, 120);
        this.btnAkcja.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(6, 95, 120);
        this.btnAkcja.OverrideFocus.Border.ColorStyle = PaletteColorStyle.Solid;
        this.btnAkcja.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.All;
        this.btnAkcja.OverrideFocus.Border.Rounding = 12;
        this.btnAkcja.OverrideFocus.Border.Width = 1;
        this.btnAkcja.TabIndex = 3;
        this.btnAkcja.Text = "Szukaj";
        this.btnAkcja.Values.Text = "Szukaj";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private KryptonLabel lblTitle;
    private KryptonLabel lblSubtitle;
    private KryptonLabel lblNumerPolisy;
    private KryptonTextBox txtNumerPolisy;
    private KryptonCheckBox chkPolisa;
    private KryptonCheckBox chkOferta;
    private KryptonButton btnAkcja;
}
