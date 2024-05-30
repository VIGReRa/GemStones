using ClassLibrary;
using DesktopGemStones;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Necklace necklace = NecklaceFactory.CreateNacklace();
            NeclaceCalculator neclaceCalculator = new NeclaceCalculator();
            double totalWeight = NeclaceCalculator.GetTotalWeight();
            double totalPrice = NeclaceCalculator.GetTotalPrice();
            NeclacePrinter neclacePrinter = new NeclacePrinter();
            NeclacePrinter.Print(totalWeight, totalPrice);

            
            InitializeComponent();
            int i;
            for (i = 0; i < Necklace.gemstonesPr.Count; i++)
            {
                listBox1.Items.Add(Necklace.gemstonesPr[i].Name);
                
            }
            
            for (i = 0; i < Necklace.gemstonesSe.Count; i++)
            {
                listBox1.Items.Add(Necklace.gemstonesSe[i].Name);

            }

            label2.Text = Convert.ToString(totalWeight);
            label4.Text = Convert.ToString(totalPrice);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedItems.Count > 0)
            {
                int i = 0;
                for (i = 0; i < (Necklace.gemstonesPr.Count); i++)
                {
                    if (Convert.ToString(listBox1.SelectedItem) == Necklace.gemstonesPr[i].Name)
                    {
                        Necklace.gemstonesPr.RemoveAt(listBox1.SelectedIndex);
                        listBox1.Items.Remove(listBox1.SelectedItem);
                        double totalWeight = NeclaceCalculator.GetTotalWeight();
                        double totalPrice = NeclaceCalculator.GetTotalPrice();
                        NeclacePrinter.Print(totalWeight, totalPrice);
                        label2.Text = Convert.ToString(totalWeight);
                        label4.Text = Convert.ToString(totalPrice);


                    }
                }
                for (i = 0; i < (Necklace.gemstonesSe.Count); i++) { 
                    if (Convert.ToString(listBox1.SelectedItem) == Necklace.gemstonesSe[i].Name)
                    {
                        Necklace.gemstonesSe.RemoveAt(i);
                        listBox1.Items.Remove(listBox1.SelectedItem);
                        double totalWeight = NeclaceCalculator.GetTotalWeight();
                        double totalPrice = NeclaceCalculator.GetTotalPrice();
                        NeclacePrinter.Print(totalWeight, totalPrice);
                        label2.Text = Convert.ToString(totalWeight);
                        label4.Text = Convert.ToString(totalPrice);
                    }
                }

            }
            
        }

        public static class StaticData
        {
            //Буфер данных
            public static String Name = String.Empty;
            public static String Color = String.Empty;
            public static String Hardness = String.Empty;
            public static String Weight = String.Empty;
            public static String Price = String.Empty;
            public static String Clarity = String.Empty;
            public static String CutShape = String.Empty;
            public static String Origin = String.Empty;
            public static String Popularity = String.Empty;
        }
        private void button2_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedItems.Count > 0)
            {
                for (int i = 0; i < Necklace.gemstonesPr.Count; i++)
                {
                    if ((Convert.ToString(listBox1.SelectedItem) == Necklace.gemstonesPr[i].Name) &
                          (Necklace.gemstonesPr[i].GetType() == typeof(CuttingType)))
                    {
                        StaticData.Name = Necklace.gemstonesPr[i].Name;
                        StaticData.Color = Necklace.gemstonesPr[i].Color;
                        StaticData.Hardness = Convert.ToString(Necklace.gemstonesPr[i].Hardness);
                        StaticData.Weight = Convert.ToString(Necklace.gemstonesPr[i].Weight);
                        StaticData.Price = Convert.ToString(Necklace.gemstonesPr[i].Price);
                        StaticData.Clarity = Convert.ToString(Necklace.gemstonesPr[i].Clarity);
                        StaticData.CutShape = Necklace.gemstonesPr[i].CutShape;

                        Edit edit = new Edit();
                        edit.ShowDialog();
                        Necklace.gemstonesPr[i].Name = StaticData.Name;
                        Necklace.gemstonesPr[i].Color = StaticData.Color;
                        Necklace.gemstonesPr[i].Hardness = int.Parse(StaticData.Hardness);
                        Necklace.gemstonesPr[i].Weight = int.Parse(StaticData.Weight);
                        Necklace.gemstonesPr[i].Price = int.Parse(StaticData.Price);
                        Necklace.gemstonesPr[i].Clarity = int.Parse(StaticData.Clarity);
                        Necklace.gemstonesPr[i].CutShape = StaticData.CutShape;
                        listBox1.Items.Clear();
                        
                        for (i = 0; i < Necklace.gemstonesPr.Count; i++)
                        {
                            listBox1.Items.Add(Necklace.gemstonesPr[i].Name);

                        }

                        for (i = 0; i < Necklace.gemstonesSe.Count; i++)
                        {
                            listBox1.Items.Add(Necklace.gemstonesSe[i].Name);

                        }
                        double totalWeight = NeclaceCalculator.GetTotalWeight();
                        double totalPrice = NeclaceCalculator.GetTotalPrice();
                        NeclacePrinter.Print(totalWeight, totalPrice);
                        label2.Text = Convert.ToString(totalWeight);
                        label4.Text = Convert.ToString(totalPrice);

                    }
                }
                for (int i = 0; i < Necklace.gemstonesSe.Count; i++)
                {
                    if ((Convert.ToString(listBox1.SelectedItem) == Necklace.gemstonesSe[i].Name) &
                          (Necklace.gemstonesSe[i].GetType() == typeof(SemiPreciousGemstone)))

                    {
                        StaticData.Name = Necklace.gemstonesSe[i].Name;
                        StaticData.Color = Necklace.gemstonesSe[i].Color;
                        StaticData.Hardness = Convert.ToString(Necklace.gemstonesSe[i].Hardness);
                        StaticData.Weight = Convert.ToString(Necklace.gemstonesSe[i].Weight);
                        StaticData.Price = Convert.ToString(Necklace.gemstonesSe[i].Price);
                        StaticData.Origin = Necklace.gemstonesSe[i].Origin;
                        StaticData.Popularity = Necklace.gemstonesSe[i].Popularity;

                        Edit_Se edit_se = new Edit_Se();
                        edit_se.ShowDialog();
                        Necklace.gemstonesSe[i].Name = StaticData.Name;
                        Necklace.gemstonesSe[i].Color = StaticData.Color;
                        Necklace.gemstonesSe[i].Hardness = int.Parse(StaticData.Hardness);
                        Necklace.gemstonesSe[i].Weight = int.Parse(StaticData.Weight);
                        Necklace.gemstonesSe[i].Price = int.Parse(StaticData.Price);
                        Necklace.gemstonesSe[i].Origin = StaticData.Origin;
                        Necklace.gemstonesSe[i].Popularity = StaticData.Popularity;
                        listBox1.Items.Clear();

                        for (i = 0; i < Necklace.gemstonesPr.Count; i++)
                        {
                            listBox1.Items.Add(Necklace.gemstonesPr[i].Name);

                        }

                        for (i = 0; i < Necklace.gemstonesSe.Count; i++)
                        {
                            listBox1.Items.Add(Necklace.gemstonesSe[i].Name);

                        }
                        double totalWeight = NeclaceCalculator.GetTotalWeight();
                        double totalPrice = NeclaceCalculator.GetTotalPrice();
                        NeclacePrinter.Print(totalWeight, totalPrice);
                        label2.Text = Convert.ToString(totalWeight);
                        label4.Text = Convert.ToString(totalPrice);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Add add = new Add();
            add.ShowDialog();
            listBox1.Items.Clear();
            int i;
            for (i = 0; i < Necklace.gemstonesPr.Count; i++)
            {
                listBox1.Items.Add(Necklace.gemstonesPr[i].Name);

            }

            for (i = 0; i < Necklace.gemstonesSe.Count; i++)
            {
                listBox1.Items.Add(Necklace.gemstonesSe[i].Name);

            }
            double totalWeight = NeclaceCalculator.GetTotalWeight();
            double totalPrice = NeclaceCalculator.GetTotalPrice();
            NeclacePrinter.Print(totalWeight, totalPrice);
            label2.Text = Convert.ToString(totalWeight);
            label4.Text = Convert.ToString(totalPrice);

        }
    }
        
        
}