using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U200920021_DORTİSLEM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             comboBox1.SelectedIndex = 0;
            if (comboBox1.Items.Contains("%") == false)
            {
                comboBox1.Items.Add("%");
            }
            
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı1 = Convert.ToInt32(textBox2.Text);
            int sayı2 = Convert.ToInt32(textBox3.Text);
            int Sonuc = 0;


            if(comboBox1.SelectedIndex ==1) //toplama
            {

                Sonuc = sayı1 + sayı2;
            }
            textBox1.Text = Sonuc.ToString();

           if(comboBox1.SelectedIndex ==2) //çıkarma
           {
                Sonuc = sayı1 - sayı2;
                    
           }
            textBox1.Text = Sonuc.ToString();
            if (comboBox1.SelectedIndex == 3) //çarpma
            {
                Sonuc = sayı1 * sayı2;

            }
            textBox1.Text = Sonuc.ToString();
            if (comboBox1.SelectedIndex == 4) //bölme
            {
                Sonuc = sayı1 / sayı2;

            }
            textBox1.Text = Sonuc.ToString();
            if (comboBox1.SelectedIndex == 5) //Modalma
            {
                Sonuc = sayı1 % sayı2;

            }
            textBox1.Text = Sonuc.ToString();

        } 

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
