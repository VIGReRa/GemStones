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
using WinFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace DesktopGemStones
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
            
            comboBox1.Text = "Выберите тип камня";
            comboBox1.Items.AddRange(new string[] { "Драгоценный", "Полудрагоценный" });
            textBoxName.Enabled = false;
            textBoxName.Visible = false;
            textBoxColor.Enabled = false;
            textBoxColor.Visible = false;
            textBoxHardness.Enabled = false;
            textBoxHardness.Visible = false;
            textBoxWeight.Enabled = false;
            textBoxWeight.Visible = false;
            textBoxPrice.Enabled = false;
            textBoxPrice.Visible = false;
            textBoxClarity.Enabled = false;
            textBoxClarity.Visible = false;
            textBoxCutShape.Enabled = false;
            textBoxCutShape.Visible = false;
            textBoxOrigin.Enabled = false;
            textBoxOrigin.Visible = false;
            textBoxPopularity.Enabled = false;
            textBoxPopularity.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBoxName.Enabled = true;
                textBoxName.Visible = true;
                textBoxName.ForeColor = Color.Gray;
                textBoxName.Text = "Введите название...";
                label1.Visible = true;
                textBoxColor.Enabled = true;
                textBoxColor.Visible = true;
                textBoxColor.ForeColor = Color.Gray;
                textBoxColor.Text = "Введите цвет...";
                label2.Visible = true;
                textBoxHardness.Enabled = true;
                textBoxHardness.Visible = true;
                textBoxHardness.ForeColor = Color.Gray;
                textBoxHardness.Text = "Введите твердость от 1 до 10...";
                label3.Visible = true;
                textBoxWeight.Enabled = true;
                textBoxWeight.Visible = true;
                textBoxWeight.ForeColor = Color.Gray;
                textBoxWeight.Text = "Введите вес...";
                label4.Visible = true;
                textBoxPrice.Enabled = true;
                textBoxPrice.Visible = true;
                textBoxPrice.ForeColor = Color.Gray;
                textBoxPrice.Text = "Введите цену...";
                label5.Visible = true;
                textBoxClarity.Enabled = true;
                textBoxClarity.Visible = true;
                textBoxClarity.ForeColor = Color.Gray;
                textBoxClarity.Text = "Введите чистоту от 1 до 10...";
                label6.Visible = true;
                textBoxCutShape.Enabled = true;
                textBoxCutShape.Visible = true;
                textBoxCutShape.ForeColor = Color.Gray;
                textBoxCutShape.Text = "Введите тип огранки...";
                label7.Visible = true;
                textBoxOrigin.Enabled = false;
                textBoxOrigin.Visible = false;
                label8.Visible = false;
                textBoxPopularity.Enabled = false;
                textBoxPopularity.Visible = false;
                label9.Visible = false;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                textBoxName.Enabled = true;
                textBoxName.Visible = true;
                textBoxName.ForeColor = Color.Gray;
                textBoxName.Text = "Введите название...";
                label1.Visible = true;
                textBoxColor.Enabled = true;
                textBoxColor.Visible = true;
                textBoxColor.ForeColor = Color.Gray;
                textBoxColor.Text = "Введите цвет...";
                label2.Visible = true;
                textBoxHardness.Enabled = true;
                textBoxHardness.Visible = true;
                textBoxHardness.ForeColor = Color.Gray;
                textBoxHardness.Text = "Введите твердость от 1 до 10...";
                label3.Visible = true;
                textBoxWeight.Enabled = true;
                textBoxWeight.Visible = true;
                textBoxWeight.ForeColor = Color.Gray;
                textBoxWeight.Text = "Введите вес...";
                label4.Visible = true;
                textBoxPrice.Enabled = true;
                textBoxPrice.Visible = true;
                textBoxPrice.ForeColor = Color.Gray;
                textBoxPrice.Text = "Введите цену...";
                label5.Visible = true;
                textBoxOrigin.Enabled = true;
                textBoxOrigin.Visible = true;
                textBoxOrigin.ForeColor = Color.Gray;
                textBoxOrigin.Text = "Введите месторождение...";
                label8.Visible = true;
                textBoxPopularity.Enabled = true;
                textBoxPopularity.Visible = true;
                textBoxPopularity.ForeColor = Color.Gray;
                textBoxPopularity.Text = "Введите уровень популярности...";
                label9.Visible = true;
                textBoxClarity.Enabled = false;
                textBoxClarity.Visible = false;
                label6.Visible = false;
                textBoxCutShape.Enabled = false;
                textBoxCutShape.Visible = false;
                label7.Visible = false;
            }
        }

        private void textBoxName_Enter(object sender, EventArgs e)
        {
            textBoxName.Text = null;
            textBoxName.ForeColor = Color.Black;
        }

        private void textBoxColor_Enter(object sender, EventArgs e)
        {
            textBoxColor.Text = null;
            textBoxColor.ForeColor = Color.Black;
        }

        private void textBoxHardness_Enter(object sender, EventArgs e)
        {
            textBoxHardness.Text = null;
            textBoxHardness.ForeColor = Color.Black;
        }

        private void textBoxWeight_Enter(object sender, EventArgs e)
        {
            textBoxWeight.Text = null;
            textBoxWeight.ForeColor = Color.Black;
        }

        private void textBoxPrice_Enter(object sender, EventArgs e)
        {
            textBoxPrice.Text = null;
            textBoxPrice.ForeColor = Color.Black;
        }

        private void textBoxOrigin_Enter(object sender, EventArgs e)
        {
            textBoxOrigin.Text = null;
            textBoxOrigin.ForeColor = Color.Black;
        }

        private void textBoxClarity_Enter(object sender, EventArgs e)
        {
            textBoxClarity.Text = null;
            textBoxClarity.ForeColor = Color.Black;
        }

        private void textBoxPopularity_Enter(object sender, EventArgs e)
        {
            textBoxPopularity.Text = null;
            textBoxPopularity.ForeColor = Color.Black;
        }

        private void textBoxCutShape_Enter(object sender, EventArgs e)
        {
            textBoxCutShape.Text = null;
            textBoxCutShape.ForeColor = Color.Black;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
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

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                bool a,b,c,d;
                a = is_valid_int(textBoxWeight);
                b= is_valid_int(textBoxPrice);
                c= is_valid_int(textBoxHardness);
                d= is_valid_int(textBoxClarity);
                if (a == true && b ==true && c==true && d==true)
                {
                    CuttingType pr = new()
                    {
                        Name = textBoxName.Text,
                        Color = textBoxColor.Text,
                        Hardness = int.Parse(textBoxHardness.Text),
                        Weight = int.Parse(textBoxWeight.Text),
                        Price = int.Parse(textBoxPrice.Text),
                        Clarity = int.Parse(textBoxClarity.Text),
                        CutShape = textBoxCutShape.Text
                    };
                    Necklace necklace = new();
                    necklace.AddGemStonePr(pr);

                    this.Close();

                }
                else if (a == false | b == false | c == false | d == false)
                {
                    Error error = new Error();
                    error.ShowDialog();

                }

                
            }
            if (comboBox1.SelectedIndex == 1)
            {
                bool a, b, c;
                a = is_valid_int(textBoxWeight);
                b = is_valid_int(textBoxPrice);
                c = is_valid_int(textBoxHardness);
                
                if (a == true && b == true && c == true )
                {
                    SemiPreciousGemstone semi = new()
                    {
                        Name = textBoxName.Text,
                        Color = textBoxColor.Text,
                        Hardness = int.Parse(textBoxHardness.Text),
                        Weight = int.Parse(textBoxWeight.Text),
                        Price = int.Parse(textBoxPrice.Text),
                        Origin = textBoxOrigin.Text,
                        Popularity = textBoxPopularity.Text
                    };
                    Necklace necklace = new();
                    necklace.AddGemStoneSe(semi);

                    this.Close();
                }
                else if (a == false | b == false | c == false)
                {
                    Error error = new Error();
                    error.ShowDialog();
                }
            }
        }
    }
}
