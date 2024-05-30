﻿using System;
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
    public partial class Edit_Se : Form
    {
        public Edit_Se()
        {
            InitializeComponent();
            textBox1.Text = StaticData.Name;
            textBox2.Text = StaticData.Color;
            textBox3.Text = StaticData.Hardness;
            textBox4.Text = StaticData.Weight;
            textBox5.Text = StaticData.Price;
            textBox6.Text = StaticData.Origin;
            textBox7.Text = StaticData.Popularity;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaticData.Name = textBox1.Text;
            StaticData.Color = textBox2.Text;
            StaticData.Hardness = textBox3.Text;
            StaticData.Weight = textBox4.Text;
            StaticData.Price = textBox5.Text;
            StaticData.Origin = textBox6.Text;
            StaticData.Popularity = textBox7.Text;
            this.Close();
        }
    }
}
