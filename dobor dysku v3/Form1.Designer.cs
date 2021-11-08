namespace dobor_dysku_v3
{
    partial class Kalkulator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kalkulator));
            this.mcbSelectResolution = new MetroFramework.Controls.MetroComboBox();
            this.mtbShowBitrate = new MetroFramework.Controls.MetroTextBox();
            this.mtbHowCameras = new MetroFramework.Controls.MetroTextBox();
            this.mtbHowDay = new MetroFramework.Controls.MetroTextBox();
            this.mb1Do = new MetroFramework.Controls.MetroButton();
            this.mbClear = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mrbH265plus = new MetroFramework.Controls.MetroRadioButton();
            this.mrbH265 = new MetroFramework.Controls.MetroRadioButton();
            this.mrbH64 = new MetroFramework.Controls.MetroRadioButton();
            this.mtbDisplayResult1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.mtbDisplayResult2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.mtb1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // mcbSelectResolution
            // 
            this.mcbSelectResolution.FormattingEnabled = true;
            this.mcbSelectResolution.ItemHeight = 23;
            this.mcbSelectResolution.Items.AddRange(new object[] {
            "1 Mpx (720p - 1280 x 720)",
            "1,3 Mpx (1280 x 960)",
            "2 Mpx (1080p - 1920 x 1080)",
            "4 Mpx (2592 x 1520)",
            "5 Mpx (2592 x 1944)",
            "6 Mpx (2816 x 2112)",
            "8 Mpx (2160p - 3840 x 2160)",
            "12 Mpx (4000 x 3000)"});
            this.mcbSelectResolution.Location = new System.Drawing.Point(193, 84);
            this.mcbSelectResolution.Name = "mcbSelectResolution";
            this.mcbSelectResolution.Size = new System.Drawing.Size(216, 29);
            this.mcbSelectResolution.TabIndex = 0;
            this.mcbSelectResolution.UseSelectable = true;
            this.mcbSelectResolution.SelectedIndexChanged += new System.EventHandler(this.mcb1_SelectedIndexChanged);
            // 
            // mtbShowBitrate
            // 
            // 
            // 
            // 
            this.mtbShowBitrate.CustomButton.Image = null;
            this.mtbShowBitrate.CustomButton.Location = new System.Drawing.Point(66, 1);
            this.mtbShowBitrate.CustomButton.Name = "";
            this.mtbShowBitrate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbShowBitrate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbShowBitrate.CustomButton.TabIndex = 1;
            this.mtbShowBitrate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbShowBitrate.CustomButton.UseSelectable = true;
            this.mtbShowBitrate.CustomButton.Visible = false;
            this.mtbShowBitrate.Lines = new string[0];
            this.mtbShowBitrate.Location = new System.Drawing.Point(193, 130);
            this.mtbShowBitrate.MaxLength = 4;
            this.mtbShowBitrate.Name = "mtbShowBitrate";
            this.mtbShowBitrate.PasswordChar = '\0';
            this.mtbShowBitrate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbShowBitrate.SelectedText = "";
            this.mtbShowBitrate.SelectionLength = 0;
            this.mtbShowBitrate.SelectionStart = 0;
            this.mtbShowBitrate.ShortcutsEnabled = true;
            this.mtbShowBitrate.Size = new System.Drawing.Size(88, 23);
            this.mtbShowBitrate.TabIndex = 1;
            this.mtbShowBitrate.UseSelectable = true;
            this.mtbShowBitrate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbShowBitrate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtbShowBitrate.TextChanged += new System.EventHandler(this.mtbShowBitrate_TextChanged);
            this.mtbShowBitrate.Click += new System.EventHandler(this.mtbShowBitrate_Click);
            // 
            // mtbHowCameras
            // 
            // 
            // 
            // 
            this.mtbHowCameras.CustomButton.Image = null;
            this.mtbHowCameras.CustomButton.Location = new System.Drawing.Point(66, 1);
            this.mtbHowCameras.CustomButton.Name = "";
            this.mtbHowCameras.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbHowCameras.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbHowCameras.CustomButton.TabIndex = 1;
            this.mtbHowCameras.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbHowCameras.CustomButton.UseSelectable = true;
            this.mtbHowCameras.CustomButton.Visible = false;
            this.mtbHowCameras.Lines = new string[0];
            this.mtbHowCameras.Location = new System.Drawing.Point(193, 167);
            this.mtbHowCameras.MaxLength = 4;
            this.mtbHowCameras.Name = "mtbHowCameras";
            this.mtbHowCameras.PasswordChar = '\0';
            this.mtbHowCameras.PromptText = "Wpisz wartość";
            this.mtbHowCameras.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbHowCameras.SelectedText = "";
            this.mtbHowCameras.SelectionLength = 0;
            this.mtbHowCameras.SelectionStart = 0;
            this.mtbHowCameras.ShortcutsEnabled = true;
            this.mtbHowCameras.Size = new System.Drawing.Size(88, 23);
            this.mtbHowCameras.TabIndex = 2;
            this.mtbHowCameras.UseSelectable = true;
            this.mtbHowCameras.WaterMark = "Wpisz wartość";
            this.mtbHowCameras.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbHowCameras.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtbHowCameras.TextChanged += new System.EventHandler(this.mtbHowCameras_TextChanged);
            this.mtbHowCameras.Click += new System.EventHandler(this.mtbHowCameras_Click);
            // 
            // mtbHowDay
            // 
            // 
            // 
            // 
            this.mtbHowDay.CustomButton.Image = null;
            this.mtbHowDay.CustomButton.Location = new System.Drawing.Point(66, 1);
            this.mtbHowDay.CustomButton.Name = "";
            this.mtbHowDay.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbHowDay.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbHowDay.CustomButton.TabIndex = 1;
            this.mtbHowDay.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbHowDay.CustomButton.UseSelectable = true;
            this.mtbHowDay.CustomButton.Visible = false;
            this.mtbHowDay.Lines = new string[0];
            this.mtbHowDay.Location = new System.Drawing.Point(193, 207);
            this.mtbHowDay.MaxLength = 4;
            this.mtbHowDay.Name = "mtbHowDay";
            this.mtbHowDay.PasswordChar = '\0';
            this.mtbHowDay.PromptText = "Wpisz wartość";
            this.mtbHowDay.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbHowDay.SelectedText = "";
            this.mtbHowDay.SelectionLength = 0;
            this.mtbHowDay.SelectionStart = 0;
            this.mtbHowDay.ShortcutsEnabled = true;
            this.mtbHowDay.Size = new System.Drawing.Size(88, 23);
            this.mtbHowDay.TabIndex = 3;
            this.mtbHowDay.UseSelectable = true;
            this.mtbHowDay.WaterMark = "Wpisz wartość";
            this.mtbHowDay.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbHowDay.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mb1Do
            // 
            this.mb1Do.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.mb1Do.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mb1Do.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mb1Do.ForeColor = System.Drawing.Color.Black;
            this.mb1Do.Location = new System.Drawing.Point(430, 201);
            this.mb1Do.Name = "mb1Do";
            this.mb1Do.Size = new System.Drawing.Size(94, 29);
            this.mb1Do.Style = MetroFramework.MetroColorStyle.White;
            this.mb1Do.TabIndex = 4;
            this.mb1Do.Text = "Oblicz";
            this.mb1Do.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mb1Do.UseCustomForeColor = true;
            this.mb1Do.UseSelectable = true;
            this.mb1Do.Click += new System.EventHandler(this.mb1_Click);
            this.mb1Do.Enter += new System.EventHandler(this.mb1Do_Enter);
            this.mb1Do.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mb1Do_KeyPress);
            // 
            // mbClear
            // 
            this.mbClear.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mbClear.Location = new System.Drawing.Point(430, 84);
            this.mbClear.Name = "mbClear";
            this.mbClear.Size = new System.Drawing.Size(94, 29);
            this.mbClear.TabIndex = 5;
            this.mbClear.Text = "Wyczyść";
            this.mbClear.UseSelectable = true;
            this.mbClear.Click += new System.EventHandler(this.mbClear_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(51, 89);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(138, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Wybierz rozdzielczość";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(21, 131);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(169, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Proponowany bitrate [Kb/s]";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(112, 169);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(75, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Ilość kamer";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(131, 207);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(56, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Ilość dni";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mrbH265plus);
            this.groupBox1.Controls.Add(this.mrbH265);
            this.groupBox1.Controls.Add(this.mrbH64);
            this.groupBox1.Location = new System.Drawing.Point(193, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(88, 77);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // mrbH265plus
            // 
            this.mrbH265plus.AutoSize = true;
            this.mrbH265plus.Location = new System.Drawing.Point(6, 55);
            this.mrbH265plus.Name = "mrbH265plus";
            this.mrbH265plus.Size = new System.Drawing.Size(61, 15);
            this.mrbH265plus.TabIndex = 2;
            this.mrbH265plus.Text = "H.265+";
            this.mrbH265plus.UseSelectable = true;
            this.mrbH265plus.CheckedChanged += new System.EventHandler(this.mrb3_CheckedChanged);
            // 
            // mrbH265
            // 
            this.mrbH265.AutoSize = true;
            this.mrbH265.Location = new System.Drawing.Point(6, 34);
            this.mrbH265.Name = "mrbH265";
            this.mrbH265.Size = new System.Drawing.Size(53, 15);
            this.mrbH265.TabIndex = 1;
            this.mrbH265.Text = "H.265";
            this.mrbH265.UseSelectable = true;
            this.mrbH265.CheckedChanged += new System.EventHandler(this.mrb2_CheckedChanged);
            // 
            // mrbH64
            // 
            this.mrbH64.AutoSize = true;
            this.mrbH64.Location = new System.Drawing.Point(6, 13);
            this.mrbH64.Name = "mrbH64";
            this.mrbH64.Size = new System.Drawing.Size(53, 15);
            this.mrbH64.TabIndex = 0;
            this.mrbH64.Text = "H.264";
            this.mrbH64.UseSelectable = true;
            this.mrbH64.CheckedChanged += new System.EventHandler(this.mrb1_CheckedChanged);
            // 
            // mtbDisplayResult1
            // 
            this.mtbDisplayResult1.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.mtbDisplayResult1.CustomButton.AllowDrop = true;
            this.mtbDisplayResult1.CustomButton.AutoSize = true;
            this.mtbDisplayResult1.CustomButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.mtbDisplayResult1.CustomButton.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)), true);
            this.mtbDisplayResult1.CustomButton.ForeColor = System.Drawing.Color.Black;
            this.mtbDisplayResult1.CustomButton.Image = null;
            this.mtbDisplayResult1.CustomButton.Location = new System.Drawing.Point(66, 1);
            this.mtbDisplayResult1.CustomButton.Name = "";
            this.mtbDisplayResult1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbDisplayResult1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbDisplayResult1.CustomButton.TabIndex = 1;
            this.mtbDisplayResult1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbDisplayResult1.CustomButton.UseSelectable = true;
            this.mtbDisplayResult1.CustomButton.Visible = false;
            this.mtbDisplayResult1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mtbDisplayResult1.Lines = new string[0];
            this.mtbDisplayResult1.Location = new System.Drawing.Point(193, 330);
            this.mtbDisplayResult1.MaxLength = 32767;
            this.mtbDisplayResult1.Name = "mtbDisplayResult1";
            this.mtbDisplayResult1.PasswordChar = '\0';
            this.mtbDisplayResult1.ReadOnly = true;
            this.mtbDisplayResult1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbDisplayResult1.SelectedText = "";
            this.mtbDisplayResult1.SelectionLength = 0;
            this.mtbDisplayResult1.SelectionStart = 0;
            this.mtbDisplayResult1.ShortcutsEnabled = false;
            this.mtbDisplayResult1.Size = new System.Drawing.Size(88, 23);
            this.mtbDisplayResult1.Style = MetroFramework.MetroColorStyle.Black;
            this.mtbDisplayResult1.TabIndex = 11;
            this.mtbDisplayResult1.UseSelectable = true;
            this.mtbDisplayResult1.WaterMarkColor = System.Drawing.Color.Black;
            this.mtbDisplayResult1.WaterMarkFont = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbDisplayResult1.Click += new System.EventHandler(this.mtbDisplayResult1_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(121, 330);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(66, 25);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Wynik";
            // 
            // mtbDisplayResult2
            // 
            // 
            // 
            // 
            this.mtbDisplayResult2.CustomButton.Image = null;
            this.mtbDisplayResult2.CustomButton.Location = new System.Drawing.Point(63, 1);
            this.mtbDisplayResult2.CustomButton.Name = "";
            this.mtbDisplayResult2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbDisplayResult2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbDisplayResult2.CustomButton.TabIndex = 1;
            this.mtbDisplayResult2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbDisplayResult2.CustomButton.UseSelectable = true;
            this.mtbDisplayResult2.CustomButton.Visible = false;
            this.mtbDisplayResult2.Lines = new string[0];
            this.mtbDisplayResult2.Location = new System.Drawing.Point(324, 330);
            this.mtbDisplayResult2.MaxLength = 32767;
            this.mtbDisplayResult2.Name = "mtbDisplayResult2";
            this.mtbDisplayResult2.PasswordChar = '\0';
            this.mtbDisplayResult2.ReadOnly = true;
            this.mtbDisplayResult2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbDisplayResult2.SelectedText = "";
            this.mtbDisplayResult2.SelectionLength = 0;
            this.mtbDisplayResult2.SelectionStart = 0;
            this.mtbDisplayResult2.ShortcutsEnabled = true;
            this.mtbDisplayResult2.Size = new System.Drawing.Size(85, 23);
            this.mtbDisplayResult2.TabIndex = 13;
            this.mtbDisplayResult2.UseSelectable = true;
            this.mtbDisplayResult2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbDisplayResult2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(281, 331);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(41, 19);
            this.metroLabel6.TabIndex = 14;
            this.metroLabel6.Text = ", czyli";
            this.metroLabel6.Click += new System.EventHandler(this.metroLabel6_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(118, 245);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(71, 19);
            this.metroLabel7.TabIndex = 15;
            this.metroLabel7.Text = "Kompresja";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(121, 328);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(66, 25);
            this.metroLabel8.TabIndex = 12;
            this.metroLabel8.Text = "Wynik";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel9.Location = new System.Drawing.Point(522, 350);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(25, 15);
            this.metroLabel9.TabIndex = 17;
            this.metroLabel9.Text = "v1.0";
            this.metroLabel9.Click += new System.EventHandler(this.metroLabel9_Click);
            // 
            // mtb1
            // 
            // 
            // 
            // 
            this.mtb1.CustomButton.Image = null;
            this.mtb1.CustomButton.Location = new System.Drawing.Point(93, 1);
            this.mtb1.CustomButton.Name = "";
            this.mtb1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtb1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtb1.CustomButton.TabIndex = 1;
            this.mtb1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtb1.CustomButton.UseSelectable = true;
            this.mtb1.CustomButton.Visible = false;
            this.mtb1.Lines = new string[0];
            this.mtb1.Location = new System.Drawing.Point(409, 129);
            this.mtb1.MaxLength = 4;
            this.mtb1.Name = "mtb1";
            this.mtb1.PasswordChar = '\0';
            this.mtb1.ReadOnly = true;
            this.mtb1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtb1.SelectedText = "";
            this.mtb1.SelectionLength = 0;
            this.mtb1.SelectionStart = 0;
            this.mtb1.ShortcutsEnabled = true;
            this.mtb1.Size = new System.Drawing.Size(115, 23);
            this.mtb1.TabIndex = 18;
            this.mtb1.UseSelectable = true;
            this.mtb1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtb1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtb1.TextChanged += new System.EventHandler(this.mtb1_TextChanged);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(281, 131);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(126, 19);
            this.metroLabel10.TabIndex = 19;
            this.metroLabel10.Text = ", sumaryczny bitrate";
            this.metroLabel10.Click += new System.EventHandler(this.metroLabel10_Click);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(23, 50);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(121, 19);
            this.metroLabel11.TabIndex = 20;
            this.metroLabel11.Text = "do systemów CCTV";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::dobor_dysku_v3.Properties.Resources.Stack_Overflow_logo;
            this.pictureBox2.Location = new System.Drawing.Point(23, 314);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Kalkulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(551, 372);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.mtb1);
            this.Controls.Add(this.mtbDisplayResult1);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.mtbDisplayResult2);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mbClear);
            this.Controls.Add(this.mb1Do);
            this.Controls.Add(this.mtbHowDay);
            this.Controls.Add(this.mtbHowCameras);
            this.Controls.Add(this.mtbShowBitrate);
            this.Controls.Add(this.mcbSelectResolution);
            this.MaximizeBox = false;
            this.Name = "Kalkulator";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Kalkulator HDD";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox mcbSelectResolution;
        private MetroFramework.Controls.MetroTextBox mtbShowBitrate;
        private MetroFramework.Controls.MetroTextBox mtbHowCameras;
        private MetroFramework.Controls.MetroTextBox mtbHowDay;
        private MetroFramework.Controls.MetroButton mb1Do;
        private MetroFramework.Controls.MetroButton mbClear;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroRadioButton mrbH265plus;
        private MetroFramework.Controls.MetroRadioButton mrbH265;
        private MetroFramework.Controls.MetroRadioButton mrbH64;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox mtbDisplayResult2;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox mtbDisplayResult1;
        private MetroFramework.Controls.MetroTextBox mtb1;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

