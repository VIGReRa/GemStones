using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WinFormsApp1.Form1;

namespace DesktopGemStones
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
            textBox1.Text = StaticData.Name;
            textBox2.Text = StaticData.Color;
            textBox3.Text = StaticData.Hardness;
            textBox4.Text = StaticData.Weight;
            textBox5.Text = StaticData.Price;
            textBox6.Text = StaticData.Clarity;
            textBox7.Text = StaticData.CutShape;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        static bool is_valid_int(TextBox textBox)
        {

            bool ok = false;
            for (int i = 0; i < textBox.Text.Length; i++)

                if (textBox.Text[i] >= '0' && textBox.Text[i] <= '9')

                    ok = true;

            return ok;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool a, b, c, d;
            a = is_valid_int(textBox3);
            b = is_valid_int(textBox4);
            c = is_valid_int(textBox5);
            d = is_valid_int(textBox6);
            if (a == true && b == true && c == true && d == true)
            {

                StaticData.Name = textBox1.Text;
                StaticData.Color = textBox2.Text;
                StaticData.Hardness = textBox3.Text;
                StaticData.Weight = textBox4.Text;
                StaticData.Price = textBox5.Text;
                StaticData.Clarity = textBox6.Text;
                StaticData.CutShape = textBox7.Text;
                this.Close();
            }
            else if (a == false | b == false | c == false | d == false)
            {
                Error error = new Error();
                error.ShowDialog();

            }
        }
    }
}
