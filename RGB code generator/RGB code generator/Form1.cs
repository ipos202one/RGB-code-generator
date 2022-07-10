using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGB_code_generator
{
    public partial class RGBcgen : Form
    {
        public RGBcgen()
        {
            InitializeComponent();
        }

        private void HSB_ValueChanged(object sender, EventArgs e)
        {
            Red_nud.Value = Red_HSB.Value;
            Green_nud.Value = Green_HSB.Value;
            Blue_nud.Value = Blue_HSB.Value;
            BGColor.BackColor = Color.FromArgb(Red_HSB.Value, Green_HSB.Value, Blue_HSB.Value);
            compcolor.BackColor = Color.FromArgb(255-Red_HSB.Value, 255-Green_HSB.Value, 255-Blue_HSB.Value);
            Red_nud_comp.Value = 255 - Red_HSB.Value;
            Green_nud_comp.Value = 255 - Green_HSB.Value;
            Blue_nud_comp.Value = 255 - Blue_HSB.Value;
        }
        private void nud_ValueChanged(object sender, EventArgs e)
        {
            Red_HSB.Value = Convert.ToInt32(Red_nud.Value);
            Green_HSB.Value = Convert.ToInt32(Green_nud.Value);
            Blue_HSB.Value = Convert.ToInt32(Blue_nud.Value);
            BGColor.BackColor = Color.FromArgb(Convert.ToInt32(Red_nud.Value), Convert.ToInt32(Green_nud.Value), Convert.ToInt32(Blue_nud.Value));
            compcolor.BackColor = Color.FromArgb(255-Convert.ToInt32(Red_nud.Value), 255-Convert.ToInt32(Green_nud.Value), 255-Convert.ToInt32(Blue_nud.Value));
        }

        private void BGColor_Click(object sender, EventArgs e)
        {
            Random RND = new Random();
            int RR = RND.Next(255);
            int GR = RND.Next(255);
            int BR = RND.Next(255);
            Red_nud.Value = RR;
            Green_nud.Value = GR;
            Blue_nud.Value = BR;
            Red_HSB.Value = RR;
            Green_HSB.Value = GR;
            Blue_HSB.Value = BR;
            BGColor.BackColor = Color.FromArgb(RR, GR, BR);
        }

        private void BGColor_MouseHover(object sender, EventArgs e)
        {
            ToolTip RandomColort = new ToolTip();
            RandomColort.ShowAlways = true;
            RandomColort.SetToolTip(BGColor, "Click for random color");
        }

        private void RGBcgen_Load(object sender, EventArgs e)
        {

        }

        private void compcolor_MouseHover(object sender, EventArgs e)
        {
            ToolTip CompColort = new ToolTip();
            CompColort.ShowAlways = true;
            CompColort.SetToolTip(compcolor, "Complementary color");
        }
    }
}
