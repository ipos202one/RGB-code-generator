namespace RGB_code_generator
{
    partial class RGBcgen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RGBcgen));
            this.Red_HSB = new System.Windows.Forms.HScrollBar();
            this.Red_nud = new System.Windows.Forms.NumericUpDown();
            this.Red_txt = new System.Windows.Forms.Label();
            this.Green_txt = new System.Windows.Forms.Label();
            this.Blue_txt = new System.Windows.Forms.Label();
            this.Green_HSB = new System.Windows.Forms.HScrollBar();
            this.Blue_HSB = new System.Windows.Forms.HScrollBar();
            this.Green_nud = new System.Windows.Forms.NumericUpDown();
            this.Blue_nud = new System.Windows.Forms.NumericUpDown();
            this.BGColor = new System.Windows.Forms.Panel();
            this.compcolor = new System.Windows.Forms.Panel();
            this.Red_nud_comp = new System.Windows.Forms.NumericUpDown();
            this.Blue_nud_comp = new System.Windows.Forms.NumericUpDown();
            this.Green_nud_comp = new System.Windows.Forms.NumericUpDown();
            this.Hex_CT = new System.Windows.Forms.Label();
            this.Hex_CTB = new System.Windows.Forms.TextBox();
            this.CompHex_CTB = new System.Windows.Forms.TextBox();
            this.apti = new System.Windows.Forms.Panel();
            this.app_icon = new System.Windows.Forms.PictureBox();
            this.app_name = new System.Windows.Forms.Label();
            this.Mini_P = new System.Windows.Forms.Panel();
            this.Mini_T = new System.Windows.Forms.Label();
            this.Exit_P = new System.Windows.Forms.Panel();
            this.Exit_T = new System.Windows.Forms.Label();
            this.PT5 = new System.Windows.Forms.Panel();
            this.PT6 = new System.Windows.Forms.Panel();
            this.PT7 = new System.Windows.Forms.Panel();
            this.PT8 = new System.Windows.Forms.Panel();
            this.PT9 = new System.Windows.Forms.Panel();
            this.PT10 = new System.Windows.Forms.Panel();
            this.PT11 = new System.Windows.Forms.Panel();
            this.PT12 = new System.Windows.Forms.Panel();
            this.PT13 = new System.Windows.Forms.Panel();
            this.PT14 = new System.Windows.Forms.Panel();
            this.PT15 = new System.Windows.Forms.Panel();
            this.PT16 = new System.Windows.Forms.Panel();
            this.PT17 = new System.Windows.Forms.Panel();
            this.PT18 = new System.Windows.Forms.Panel();
            this.PT4 = new System.Windows.Forms.Panel();
            this.PT3 = new System.Windows.Forms.Panel();
            this.PT2 = new System.Windows.Forms.Panel();
            this.PT1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Red_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blue_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Red_nud_comp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blue_nud_comp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green_nud_comp)).BeginInit();
            this.apti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.app_icon)).BeginInit();
            this.Mini_P.SuspendLayout();
            this.Exit_P.SuspendLayout();
            this.SuspendLayout();
            // 
            // Red_HSB
            // 
            this.Red_HSB.LargeChange = 1;
            this.Red_HSB.Location = new System.Drawing.Point(80, 35);
            this.Red_HSB.Maximum = 255;
            this.Red_HSB.Name = "Red_HSB";
            this.Red_HSB.Size = new System.Drawing.Size(315, 20);
            this.Red_HSB.TabIndex = 0;
            this.Red_HSB.ValueChanged += new System.EventHandler(this.HSB_ValueChanged);
            // 
            // Red_nud
            // 
            this.Red_nud.Location = new System.Drawing.Point(398, 35);
            this.Red_nud.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Red_nud.Name = "Red_nud";
            this.Red_nud.Size = new System.Drawing.Size(57, 20);
            this.Red_nud.TabIndex = 3;
            this.Red_nud.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // Red_txt
            // 
            this.Red_txt.AutoSize = true;
            this.Red_txt.ForeColor = System.Drawing.Color.Red;
            this.Red_txt.Location = new System.Drawing.Point(13, 37);
            this.Red_txt.Name = "Red_txt";
            this.Red_txt.Size = new System.Drawing.Size(53, 13);
            this.Red_txt.TabIndex = 13;
            this.Red_txt.Text = "Red color";
            // 
            // Green_txt
            // 
            this.Green_txt.AutoSize = true;
            this.Green_txt.ForeColor = System.Drawing.Color.Lime;
            this.Green_txt.Location = new System.Drawing.Point(13, 63);
            this.Green_txt.Name = "Green_txt";
            this.Green_txt.Size = new System.Drawing.Size(62, 13);
            this.Green_txt.TabIndex = 14;
            this.Green_txt.Text = "Green color";
            // 
            // Blue_txt
            // 
            this.Blue_txt.AutoSize = true;
            this.Blue_txt.ForeColor = System.Drawing.Color.Blue;
            this.Blue_txt.Location = new System.Drawing.Point(13, 89);
            this.Blue_txt.Name = "Blue_txt";
            this.Blue_txt.Size = new System.Drawing.Size(54, 13);
            this.Blue_txt.TabIndex = 15;
            this.Blue_txt.Text = "Blue color";
            // 
            // Green_HSB
            // 
            this.Green_HSB.LargeChange = 1;
            this.Green_HSB.Location = new System.Drawing.Point(80, 61);
            this.Green_HSB.Maximum = 255;
            this.Green_HSB.Name = "Green_HSB";
            this.Green_HSB.Size = new System.Drawing.Size(315, 20);
            this.Green_HSB.TabIndex = 1;
            this.Green_HSB.ValueChanged += new System.EventHandler(this.HSB_ValueChanged);
            // 
            // Blue_HSB
            // 
            this.Blue_HSB.LargeChange = 1;
            this.Blue_HSB.Location = new System.Drawing.Point(80, 87);
            this.Blue_HSB.Maximum = 255;
            this.Blue_HSB.Name = "Blue_HSB";
            this.Blue_HSB.Size = new System.Drawing.Size(315, 20);
            this.Blue_HSB.TabIndex = 2;
            this.Blue_HSB.ValueChanged += new System.EventHandler(this.HSB_ValueChanged);
            // 
            // Green_nud
            // 
            this.Green_nud.Location = new System.Drawing.Point(398, 61);
            this.Green_nud.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Green_nud.Name = "Green_nud";
            this.Green_nud.Size = new System.Drawing.Size(57, 20);
            this.Green_nud.TabIndex = 4;
            this.Green_nud.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // Blue_nud
            // 
            this.Blue_nud.Location = new System.Drawing.Point(398, 87);
            this.Blue_nud.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Blue_nud.Name = "Blue_nud";
            this.Blue_nud.Size = new System.Drawing.Size(57, 20);
            this.Blue_nud.TabIndex = 5;
            this.Blue_nud.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // BGColor
            // 
            this.BGColor.BackColor = System.Drawing.SystemColors.ControlText;
            this.BGColor.Location = new System.Drawing.Point(461, 35);
            this.BGColor.Name = "BGColor";
            this.BGColor.Size = new System.Drawing.Size(35, 72);
            this.BGColor.TabIndex = 11;
            this.BGColor.BackColorChanged += new System.EventHandler(this.BGColor_BackColorChanged);
            this.BGColor.Click += new System.EventHandler(this.BGColor_Click);
            this.BGColor.MouseHover += new System.EventHandler(this.BGColor_MouseHover);
            // 
            // compcolor
            // 
            this.compcolor.BackColor = System.Drawing.Color.White;
            this.compcolor.Location = new System.Drawing.Point(502, 35);
            this.compcolor.Name = "compcolor";
            this.compcolor.Size = new System.Drawing.Size(37, 72);
            this.compcolor.TabIndex = 12;
            this.compcolor.BackColorChanged += new System.EventHandler(this.compcolor_BackColorChanged);
            // 
            // Red_nud_comp
            // 
            this.Red_nud_comp.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Red_nud_comp.Location = new System.Drawing.Point(545, 35);
            this.Red_nud_comp.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Red_nud_comp.Name = "Red_nud_comp";
            this.Red_nud_comp.ReadOnly = true;
            this.Red_nud_comp.Size = new System.Drawing.Size(57, 20);
            this.Red_nud_comp.TabIndex = 6;
            this.Red_nud_comp.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // Blue_nud_comp
            // 
            this.Blue_nud_comp.Location = new System.Drawing.Point(545, 87);
            this.Blue_nud_comp.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Blue_nud_comp.Name = "Blue_nud_comp";
            this.Blue_nud_comp.ReadOnly = true;
            this.Blue_nud_comp.Size = new System.Drawing.Size(57, 20);
            this.Blue_nud_comp.TabIndex = 8;
            this.Blue_nud_comp.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // Green_nud_comp
            // 
            this.Green_nud_comp.Location = new System.Drawing.Point(545, 61);
            this.Green_nud_comp.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Green_nud_comp.Name = "Green_nud_comp";
            this.Green_nud_comp.ReadOnly = true;
            this.Green_nud_comp.Size = new System.Drawing.Size(57, 20);
            this.Green_nud_comp.TabIndex = 7;
            this.Green_nud_comp.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // Hex_CT
            // 
            this.Hex_CT.AutoSize = true;
            this.Hex_CT.Location = new System.Drawing.Point(13, 116);
            this.Hex_CT.Name = "Hex_CT";
            this.Hex_CT.Size = new System.Drawing.Size(54, 13);
            this.Hex_CT.TabIndex = 16;
            this.Hex_CT.Text = "Hex Code";
            // 
            // Hex_CTB
            // 
            this.Hex_CTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Hex_CTB.Location = new System.Drawing.Point(80, 113);
            this.Hex_CTB.MaxLength = 7;
            this.Hex_CTB.Name = "Hex_CTB";
            this.Hex_CTB.Size = new System.Drawing.Size(416, 20);
            this.Hex_CTB.TabIndex = 9;
            this.Hex_CTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Hex_CTB.TextChanged += new System.EventHandler(this.Hex_CTB_TextChanged);
            // 
            // CompHex_CTB
            // 
            this.CompHex_CTB.Location = new System.Drawing.Point(503, 113);
            this.CompHex_CTB.MaxLength = 7;
            this.CompHex_CTB.Name = "CompHex_CTB";
            this.CompHex_CTB.ReadOnly = true;
            this.CompHex_CTB.Size = new System.Drawing.Size(99, 20);
            this.CompHex_CTB.TabIndex = 10;
            this.CompHex_CTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CompHex_CTB.TextChanged += new System.EventHandler(this.CompHex_CTB_TextChanged);
            // 
            // apti
            // 
            this.apti.BackColor = System.Drawing.Color.White;
            this.apti.Controls.Add(this.PT18);
            this.apti.Controls.Add(this.PT17);
            this.apti.Controls.Add(this.PT16);
            this.apti.Controls.Add(this.PT15);
            this.apti.Controls.Add(this.PT14);
            this.apti.Controls.Add(this.PT13);
            this.apti.Controls.Add(this.PT12);
            this.apti.Controls.Add(this.PT11);
            this.apti.Controls.Add(this.PT10);
            this.apti.Controls.Add(this.PT9);
            this.apti.Controls.Add(this.PT8);
            this.apti.Controls.Add(this.PT7);
            this.apti.Controls.Add(this.PT6);
            this.apti.Controls.Add(this.PT5);
            this.apti.Controls.Add(this.app_icon);
            this.apti.Controls.Add(this.app_name);
            this.apti.Controls.Add(this.Mini_P);
            this.apti.Controls.Add(this.Exit_P);
            this.apti.Controls.Add(this.PT4);
            this.apti.Controls.Add(this.PT3);
            this.apti.Controls.Add(this.PT2);
            this.apti.Controls.Add(this.PT1);
            this.apti.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.apti.Location = new System.Drawing.Point(-2, -2);
            this.apti.Name = "apti";
            this.apti.Size = new System.Drawing.Size(617, 26);
            this.apti.TabIndex = 17;
            this.apti.MouseDown += new System.Windows.Forms.MouseEventHandler(this.apti_MouseDown);
            this.apti.MouseMove += new System.Windows.Forms.MouseEventHandler(this.apti_MouseMove);
            // 
            // app_icon
            // 
            this.app_icon.BackColor = System.Drawing.Color.White;
            this.app_icon.Image = global::RGB_code_generator.Properties.Resources.color;
            this.app_icon.Location = new System.Drawing.Point(8, 5);
            this.app_icon.Name = "app_icon";
            this.app_icon.Size = new System.Drawing.Size(17, 16);
            this.app_icon.TabIndex = 3;
            this.app_icon.TabStop = false;
            this.app_icon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.apti_MouseDown);
            this.app_icon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.apti_MouseMove);
            // 
            // app_name
            // 
            this.app_name.AutoSize = true;
            this.app_name.Location = new System.Drawing.Point(30, 7);
            this.app_name.Name = "app_name";
            this.app_name.Size = new System.Drawing.Size(108, 13);
            this.app_name.TabIndex = 2;
            this.app_name.Text = "RGB Code Generator";
            this.app_name.MouseDown += new System.Windows.Forms.MouseEventHandler(this.apti_MouseDown);
            this.app_name.MouseMove += new System.Windows.Forms.MouseEventHandler(this.apti_MouseMove);
            // 
            // Mini_P
            // 
            this.Mini_P.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Mini_P.Controls.Add(this.Mini_T);
            this.Mini_P.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Mini_P.Location = new System.Drawing.Point(528, 4);
            this.Mini_P.Name = "Mini_P";
            this.Mini_P.Size = new System.Drawing.Size(33, 19);
            this.Mini_P.TabIndex = 1;
            this.Mini_P.Click += new System.EventHandler(this.Mini_P_Click);
            // 
            // Mini_T
            // 
            this.Mini_T.AutoSize = true;
            this.Mini_T.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Mini_T.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mini_T.Location = new System.Drawing.Point(8, 0);
            this.Mini_T.Name = "Mini_T";
            this.Mini_T.Size = new System.Drawing.Size(16, 16);
            this.Mini_T.TabIndex = 0;
            this.Mini_T.Text = "_";
            this.Mini_T.Click += new System.EventHandler(this.Mini_P_Click);
            // 
            // Exit_P
            // 
            this.Exit_P.BackColor = System.Drawing.Color.Red;
            this.Exit_P.Controls.Add(this.Exit_T);
            this.Exit_P.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_P.Location = new System.Drawing.Point(565, 4);
            this.Exit_P.Name = "Exit_P";
            this.Exit_P.Size = new System.Drawing.Size(49, 19);
            this.Exit_P.TabIndex = 0;
            this.Exit_P.Click += new System.EventHandler(this.Exit_P_Click);
            // 
            // Exit_T
            // 
            this.Exit_T.AutoSize = true;
            this.Exit_T.Location = new System.Drawing.Point(18, 3);
            this.Exit_T.Name = "Exit_T";
            this.Exit_T.Size = new System.Drawing.Size(14, 13);
            this.Exit_T.TabIndex = 0;
            this.Exit_T.Text = "X";
            this.Exit_T.Click += new System.EventHandler(this.Exit_P_Click);
            // 
            // PT5
            // 
            this.PT5.Location = new System.Drawing.Point(144, 3);
            this.PT5.Name = "PT5";
            this.PT5.Size = new System.Drawing.Size(27, 20);
            this.PT5.TabIndex = 4;
            this.PT5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.apti_MouseDown);
            this.PT5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.apti_MouseMove);
            // 
            // PT6
            // 
            this.PT6.Location = new System.Drawing.Point(171, 3);
            this.PT6.Name = "PT6";
            this.PT6.Size = new System.Drawing.Size(28, 20);
            this.PT6.TabIndex = 5;
            this.PT6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.apti_MouseDown);
            this.PT6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.apti_MouseMove);
            // 
            // PT7
            // 
            this.PT7.Location = new System.Drawing.Point(198, 3);
            this.PT7.Name = "PT7";
            this.PT7.Size = new System.Drawing.Size(29, 20);
            this.PT7.TabIndex = 6;
            this.PT7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.apti_MouseDown);
            this.PT7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.apti_MouseMove);
            // 
            // PT8
            // 
            this.PT8.Location = new System.Drawing.Point(225, 3);
            this.PT8.Name = "PT8";
            this.PT8.Size = new System.Drawing.Size(28, 20);
            this.PT8.TabIndex = 7;
            this.PT8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.apti_MouseDown);
            this.PT8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.apti_MouseMove);
            // 
            // PT9
            // 
            this.PT9.Location = new System.Drawing.Point(252, 3);
            this.PT9.Name = "PT9";
            this.PT9.Size = new System.Drawing.Size(31, 20);
            this.PT9.TabIndex = 8;
            this.PT9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.apti_MouseDown);
            this.PT9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.apti_MouseMove);
            // 
            // PT10
            // 
            this.PT10.Location = new System.Drawing.Point(279, 3);
            this.PT10.Name = "PT10";
            this.PT10.Size = new System.Drawing.Size(30, 20);
            this.PT10.TabIndex = 8;
            this.PT10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.apti_MouseDown);
            this.PT10.MouseMove += new System.Windows.Forms.MouseEventHandler(this.apti_MouseMove);
            // 
            // PT11
            // 
            this.PT11.Location = new System.Drawing.Point(306, 3);
            this.PT11.Name = "PT11";
            this.PT11.Size = new System.Drawing.Size(28, 20);
            this.PT11.TabIndex = 8;
            this.PT11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.apti_MouseDown);
            this.PT11.MouseMove += new System.Windows.Forms.MouseEventHandler(this.apti_MouseMove);
            // 
            // PT12
            // 
            this.PT12.Location = new System.Drawing.Point(333, 3);
            this.PT12.Name = "PT12";
            this.PT12.Size = new System.Drawing.Size(31, 20);
            this.PT12.TabIndex = 8;
            this.PT12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.apti_MouseDown);
            this.PT12.MouseMove += new System.Windows.Forms.MouseEventHandler(this.apti_MouseMove);
            // 
            // PT13
            // 
            this.PT13.Location = new System.Drawing.Point(360, 3);
            this.PT13.Name = "PT13";
            this.PT13.Size = new System.Drawing.Size(27, 20);
            this.PT13.TabIndex = 8;
            this.PT13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.apti_MouseDown);
            this.PT13.MouseMove += new System.Windows.Forms.MouseEventHandler(this.apti_MouseMove);
            // 
            // PT14
            // 
            this.PT14.Location = new System.Drawing.Point(387, 3);
            this.PT14.Name = "PT14";
            this.PT14.Size = new System.Drawing.Size(29, 20);
            this.PT14.TabIndex = 8;
            this.PT14.MouseDown += new System.Windows.Forms.MouseEventHandler(this.apti_MouseDown);
            this.PT14.MouseMove += new System.Windows.Forms.MouseEventHandler(this.apti_MouseMove);
            // 
            // PT15
            // 
            this.PT15.Location = new System.Drawing.Point(414, 3);
            this.PT15.Name = "PT15";
            this.PT15.Size = new System.Drawing.Size(28, 20);
            this.PT15.TabIndex = 8;
            this.PT15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.apti_MouseDown);
            this.PT15.MouseMove += new System.Windows.Forms.MouseEventHandler(this.apti_MouseMove);
            // 
            // PT16
            // 
            this.PT16.Location = new System.Drawing.Point(441, 3);
            this.PT16.Name = "PT16";
            this.PT16.Size = new System.Drawing.Size(28, 20);
            this.PT16.TabIndex = 8;
            this.PT16.MouseDown += new System.Windows.Forms.MouseEventHandler(this.apti_MouseDown);
            this.PT16.MouseMove += new System.Windows.Forms.MouseEventHandler(this.apti_MouseMove);
            // 
            // PT17
            // 
            this.PT17.Location = new System.Drawing.Point(468, 3);
            this.PT17.Name = "PT17";
            this.PT17.Size = new System.Drawing.Size(27, 20);
            this.PT17.TabIndex = 8;
            this.PT17.MouseDown += new System.Windows.Forms.MouseEventHandler(this.apti_MouseDown);
            this.PT17.MouseMove += new System.Windows.Forms.MouseEventHandler(this.apti_MouseMove);
            // 
            // PT18
            // 
            this.PT18.Location = new System.Drawing.Point(495, 3);
            this.PT18.Name = "PT18";
            this.PT18.Size = new System.Drawing.Size(31, 20);
            this.PT18.TabIndex = 8;
            this.PT18.MouseDown += new System.Windows.Forms.MouseEventHandler(this.apti_MouseDown);
            this.PT18.MouseMove += new System.Windows.Forms.MouseEventHandler(this.apti_MouseMove);
            // 
            // PT4
            // 
            this.PT4.Location = new System.Drawing.Point(111, 3);
            this.PT4.Name = "PT4";
            this.PT4.Size = new System.Drawing.Size(35, 20);
            this.PT4.TabIndex = 5;
            // 
            // PT3
            // 
            this.PT3.Location = new System.Drawing.Point(75, 3);
            this.PT3.Name = "PT3";
            this.PT3.Size = new System.Drawing.Size(35, 20);
            this.PT3.TabIndex = 6;
            // 
            // PT2
            // 
            this.PT2.Location = new System.Drawing.Point(41, 3);
            this.PT2.Name = "PT2";
            this.PT2.Size = new System.Drawing.Size(35, 20);
            this.PT2.TabIndex = 7;
            // 
            // PT1
            // 
            this.PT1.Location = new System.Drawing.Point(7, 3);
            this.PT1.Name = "PT1";
            this.PT1.Size = new System.Drawing.Size(35, 20);
            this.PT1.TabIndex = 8;
            // 
            // RGBcgen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 145);
            this.Controls.Add(this.apti);
            this.Controls.Add(this.CompHex_CTB);
            this.Controls.Add(this.Hex_CTB);
            this.Controls.Add(this.Hex_CT);
            this.Controls.Add(this.Green_nud_comp);
            this.Controls.Add(this.Blue_nud_comp);
            this.Controls.Add(this.Red_nud_comp);
            this.Controls.Add(this.compcolor);
            this.Controls.Add(this.BGColor);
            this.Controls.Add(this.Blue_nud);
            this.Controls.Add(this.Green_nud);
            this.Controls.Add(this.Blue_HSB);
            this.Controls.Add(this.Green_HSB);
            this.Controls.Add(this.Blue_txt);
            this.Controls.Add(this.Green_txt);
            this.Controls.Add(this.Red_txt);
            this.Controls.Add(this.Red_nud);
            this.Controls.Add(this.Red_HSB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RGBcgen";
            this.Text = "RGB code generator";
            this.Load += new System.EventHandler(this.RGBcgen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Red_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blue_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Red_nud_comp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blue_nud_comp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green_nud_comp)).EndInit();
            this.apti.ResumeLayout(false);
            this.apti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.app_icon)).EndInit();
            this.Mini_P.ResumeLayout(false);
            this.Mini_P.PerformLayout();
            this.Exit_P.ResumeLayout(false);
            this.Exit_P.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar Red_HSB;
        private System.Windows.Forms.NumericUpDown Red_nud;
        private System.Windows.Forms.Label Red_txt;
        private System.Windows.Forms.Label Green_txt;
        private System.Windows.Forms.Label Blue_txt;
        private System.Windows.Forms.HScrollBar Green_HSB;
        private System.Windows.Forms.HScrollBar Blue_HSB;
        private System.Windows.Forms.NumericUpDown Green_nud;
        private System.Windows.Forms.NumericUpDown Blue_nud;
        private System.Windows.Forms.Panel BGColor;
        private System.Windows.Forms.Panel compcolor;
        private System.Windows.Forms.NumericUpDown Red_nud_comp;
        private System.Windows.Forms.NumericUpDown Blue_nud_comp;
        private System.Windows.Forms.NumericUpDown Green_nud_comp;
        private System.Windows.Forms.Label Hex_CT;
        private System.Windows.Forms.TextBox Hex_CTB;
        private System.Windows.Forms.TextBox CompHex_CTB;
        private System.Windows.Forms.Panel apti;
        private System.Windows.Forms.Panel Mini_P;
        private System.Windows.Forms.Label Mini_T;
        private System.Windows.Forms.Panel Exit_P;
        private System.Windows.Forms.Label Exit_T;
        private System.Windows.Forms.Label app_name;
        private System.Windows.Forms.PictureBox app_icon;
        private System.Windows.Forms.Panel PT18;
        private System.Windows.Forms.Panel PT17;
        private System.Windows.Forms.Panel PT16;
        private System.Windows.Forms.Panel PT15;
        private System.Windows.Forms.Panel PT14;
        private System.Windows.Forms.Panel PT13;
        private System.Windows.Forms.Panel PT12;
        private System.Windows.Forms.Panel PT11;
        private System.Windows.Forms.Panel PT10;
        private System.Windows.Forms.Panel PT9;
        private System.Windows.Forms.Panel PT8;
        private System.Windows.Forms.Panel PT7;
        private System.Windows.Forms.Panel PT6;
        private System.Windows.Forms.Panel PT5;
        private System.Windows.Forms.Panel PT4;
        private System.Windows.Forms.Panel PT3;
        private System.Windows.Forms.Panel PT2;
        private System.Windows.Forms.Panel PT1;

    }
}

