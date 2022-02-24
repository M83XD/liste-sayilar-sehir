using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                comboBox1.Items.Clear();
                int s1 = int.Parse(textBox1.Text);
                int s2 = int.Parse(textBox2.Text);
                if (s1 < s2)
                {
                    for (int i = s1; i <= s2; i++)
                    {
                        comboBox1.Items.Add(i);
                    }
                }
                else
                {
                    for (int i = s2; i <= s1; i++)
                    {
                        comboBox1.Items.Add(i);
                    }
                }




            }
            catch (Exception hata)
            {
                MessageBox.Show("Hatalı işlem. Hata : " + hata.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = comboBox1.SelectedItem.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            object[] sehir = { "Isparta", "Burdur", "Antalya", "Ankara" };
            comboBox2.Items.AddRange(sehir);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            string[] isparta = { "Atabey", "Gönen", "Eğirdir", "Keçiborlu" };
            string[] burdur = { "Ağlasun", "Tefenni", "Çavdır", "Bucak" };
            string[] konya = { "SeydiŞehir", "Çumra", "Beyşehir", "Keçiborlu" };
            string[] Antalya = { "Manavgat", "Finike", "Alanya", };
            if (comboBox2.SelectedIndex==0)
                comboBox3.Items.AddRange(isparta);
            if (comboBox2.SelectedIndex == 1)
                comboBox3.Items.AddRange(burdur);
            if (comboBox2.SelectedIndex == 2)
                comboBox3.Items.AddRange(konya);
            if (comboBox2.SelectedIndex == 3)
                comboBox3.Items.AddRange(Antalya);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            label7.Text = comboBox2.SelectedItem+" ili "+comboBox3.SelectedItem+" ilçesinde yaşıyorsunuz.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox3.Text);
        }
    }
}
