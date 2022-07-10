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
            ((System.ComponentModel.ISupportInitialize)(this.Red_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blue_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Red_nud_comp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blue_nud_comp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green_nud_comp)).BeginInit();
            this.SuspendLayout();
            // 
            // Red_HSB
            // 
            this.Red_HSB.LargeChange = 1;
            this.Red_HSB.Location = new System.Drawing.Point(79, 13);
            this.Red_HSB.Maximum = 255;
            this.Red_HSB.Name = "Red_HSB";
            this.Red_HSB.Size = new System.Drawing.Size(315, 20);
            this.Red_HSB.TabIndex = 0;
            this.Red_HSB.ValueChanged += new System.EventHandler(this.HSB_ValueChanged);
            // 
            // Red_nud
            // 
            this.Red_nud.Location = new System.Drawing.Point(397, 13);
            this.Red_nud.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Red_nud.Name = "Red_nud";
            this.Red_nud.Size = new System.Drawing.Size(57, 20);
            this.Red_nud.TabIndex = 1;
            this.Red_nud.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // Red_txt
            // 
            this.Red_txt.AutoSize = true;
            this.Red_txt.ForeColor = System.Drawing.Color.Red;
            this.Red_txt.Location = new System.Drawing.Point(12, 15);
            this.Red_txt.Name = "Red_txt";
            this.Red_txt.Size = new System.Drawing.Size(53, 13);
            this.Red_txt.TabIndex = 2;
            this.Red_txt.Text = "Red color";
            // 
            // Green_txt
            // 
            this.Green_txt.AutoSize = true;
            this.Green_txt.ForeColor = System.Drawing.Color.Lime;
            this.Green_txt.Location = new System.Drawing.Point(12, 41);
            this.Green_txt.Name = "Green_txt";
            this.Green_txt.Size = new System.Drawing.Size(62, 13);
            this.Green_txt.TabIndex = 3;
            this.Green_txt.Text = "Green color";
            // 
            // Blue_txt
            // 
            this.Blue_txt.AutoSize = true;
            this.Blue_txt.ForeColor = System.Drawing.Color.Blue;
            this.Blue_txt.Location = new System.Drawing.Point(12, 67);
            this.Blue_txt.Name = "Blue_txt";
            this.Blue_txt.Size = new System.Drawing.Size(54, 13);
            this.Blue_txt.TabIndex = 4;
            this.Blue_txt.Text = "Blue color";
            // 
            // Green_HSB
            // 
            this.Green_HSB.LargeChange = 1;
            this.Green_HSB.Location = new System.Drawing.Point(79, 39);
            this.Green_HSB.Maximum = 255;
            this.Green_HSB.Name = "Green_HSB";
            this.Green_HSB.Size = new System.Drawing.Size(315, 20);
            this.Green_HSB.TabIndex = 5;
            this.Green_HSB.ValueChanged += new System.EventHandler(this.HSB_ValueChanged);
            // 
            // Blue_HSB
            // 
            this.Blue_HSB.LargeChange = 1;
            this.Blue_HSB.Location = new System.Drawing.Point(79, 65);
            this.Blue_HSB.Maximum = 255;
            this.Blue_HSB.Name = "Blue_HSB";
            this.Blue_HSB.Size = new System.Drawing.Size(315, 20);
            this.Blue_HSB.TabIndex = 6;
            this.Blue_HSB.ValueChanged += new System.EventHandler(this.HSB_ValueChanged);
            // 
            // Green_nud
            // 
            this.Green_nud.Location = new System.Drawing.Point(397, 39);
            this.Green_nud.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Green_nud.Name = "Green_nud";
            this.Green_nud.Size = new System.Drawing.Size(57, 20);
            this.Green_nud.TabIndex = 7;
            this.Green_nud.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // Blue_nud
            // 
            this.Blue_nud.Location = new System.Drawing.Point(397, 65);
            this.Blue_nud.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Blue_nud.Name = "Blue_nud";
            this.Blue_nud.Size = new System.Drawing.Size(57, 20);
            this.Blue_nud.TabIndex = 8;
            this.Blue_nud.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // BGColor
            // 
            this.BGColor.BackColor = System.Drawing.SystemColors.ControlText;
            this.BGColor.Location = new System.Drawing.Point(460, 13);
            this.BGColor.Name = "BGColor";
            this.BGColor.Size = new System.Drawing.Size(35, 72);
            this.BGColor.TabIndex = 9;
            this.BGColor.Click += new System.EventHandler(this.BGColor_Click);
            this.BGColor.MouseHover += new System.EventHandler(this.BGColor_MouseHover);
            // 
            // compcolor
            // 
            this.compcolor.BackColor = System.Drawing.Color.White;
            this.compcolor.Location = new System.Drawing.Point(501, 13);
            this.compcolor.Name = "compcolor";
            this.compcolor.Size = new System.Drawing.Size(37, 72);
            this.compcolor.TabIndex = 10;
            this.compcolor.MouseHover += new System.EventHandler(this.compcolor_MouseHover);
            // 
            // Red_nud_comp
            // 
            this.Red_nud_comp.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Red_nud_comp.Location = new System.Drawing.Point(544, 13);
            this.Red_nud_comp.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Red_nud_comp.Name = "Red_nud_comp";
            this.Red_nud_comp.ReadOnly = true;
            this.Red_nud_comp.Size = new System.Drawing.Size(57, 20);
            this.Red_nud_comp.TabIndex = 11;
            this.Red_nud_comp.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // Blue_nud_comp
            // 
            this.Blue_nud_comp.Location = new System.Drawing.Point(544, 65);
            this.Blue_nud_comp.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Blue_nud_comp.Name = "Blue_nud_comp";
            this.Blue_nud_comp.ReadOnly = true;
            this.Blue_nud_comp.Size = new System.Drawing.Size(57, 20);
            this.Blue_nud_comp.TabIndex = 12;
            this.Blue_nud_comp.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // Green_nud_comp
            // 
            this.Green_nud_comp.Location = new System.Drawing.Point(544, 39);
            this.Green_nud_comp.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Green_nud_comp.Name = "Green_nud_comp";
            this.Green_nud_comp.ReadOnly = true;
            this.Green_nud_comp.Size = new System.Drawing.Size(57, 20);
            this.Green_nud_comp.TabIndex = 13;
            this.Green_nud_comp.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // RGBcgen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 100);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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

    }
}

