using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SS_OpenCV
{
    public partial class FilterBox : Form
    {
        public Boolean filter_3;
        public FilterBox()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Weight_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int opt = comboBox1.SelectedIndex;
            switch(opt){
                case 0: panel2.Visible = false; panel1.Visible = true;
                    text13x3.Text = "1";
                    text23x3.Text = "1";
                    text33x3.Text = "1";
                    text43x3.Text = "1";
                    text53x3.Text = "1";
                    text63x3.Text = "1";
                    text73x3.Text = "1";
                    text83x3.Text = "1";
                    text93x3.Text = "1";
                    textWeight.Text = "9";
                    filter_3 = true;
                    break;
                case 1: panel1.Visible = false; panel2.Visible = true;
                    text15x5.Text = "1";
                    text25x5.Text = "1";
                    text35x5.Text = "1";
                    text45x5.Text = "1";
                    text55x5.Text = "1";
                    text65x5.Text = "1";
                    text75x5.Text = "1";
                    text85x5.Text = "1";
                    text95x5.Text = "1";
                    text105x5.Text = "1";
                    text115x5.Text = "1";
                    text125x5.Text = "1";
                    text135x5.Text = "1";
                    text145x5.Text = "1";
                    text155x5.Text = "1";
                    text165x5.Text = "1";
                    text175x5.Text = "1";
                    text185x5.Text = "1";
                    text195x5.Text = "1";
                    text205x5.Text = "1";
                    text215x5.Text = "1";
                    text225x5.Text = "1";
                    text235x5.Text = "1";
                    text245x5.Text = "1";
                    text255x5.Text = "1";
                    textWeight.Text = "25";
                    filter_3 = false;
                    break;
                case 2: panel2.Visible = false; panel1.Visible = true;
                    text13x3.Text = "1";
                    text23x3.Text = "2";
                    text33x3.Text = "1";
                    text43x3.Text = "2";
                    text53x3.Text = "4";
                    text63x3.Text = "2";
                    text73x3.Text = "1";
                    text83x3.Text = "2";
                    text93x3.Text = "1";
                    textWeight.Text = "16";
                    filter_3 = true;
                    break;
                case 3: panel2.Visible = false; panel1.Visible = true;
                    text13x3.Text = "1";
                    text23x3.Text = "-2";
                    text33x3.Text = "1";
                    text43x3.Text = "-2";
                    text53x3.Text = "4";
                    text63x3.Text = "-2";
                    text73x3.Text = "1";
                    text83x3.Text = "-2";
                    text93x3.Text = "1";
                    textWeight.Text = "1";
                    filter_3 = true;
                    break;
                case 4: panel2.Visible = false; panel1.Visible = true;
                    text13x3.Text = "-1";
                    text23x3.Text = "-1";
                    text33x3.Text = "-1";
                    text43x3.Text = "-1";
                    text53x3.Text = "9";
                    text63x3.Text = "-1";
                    text73x3.Text = "-1";
                    text83x3.Text = "-1";
                    text93x3.Text = "-1";
                    textWeight.Text = "1";
                    filter_3 = true;
                    break;
            }
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
