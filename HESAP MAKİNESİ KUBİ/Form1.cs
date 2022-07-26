using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HESAP_MAKİNESİ_KUBİ
{
    public partial class Form1 : Form
    {
        public static double eleman1 = 0;
        public static double eleman2 = 0;
        
        
        
        public int asayac = 0;
        public int esayac = 0;
        public int csayac = 0;
        public int bsayac = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }



        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                
            }
            else
            {
                textBox1.Text = "0";
            }
        }

        private void arti_Click(object sender, EventArgs e)
        {
            asayac++;
            
            if(asayac==1)
            {
                eleman1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";
            }
            
            

            

        }

        private void esittir_Click(object sender, EventArgs e)
        {
            if (asayac==1)
            {
                eleman2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";

                double toplam = eleman1 + eleman2;
               textBox1.Text = toplam.ToString();
                asayac = 0;

            }
            else if (esayac==1)
            {
                eleman2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";

                double fark = eleman1 - eleman2;
                textBox1.Text = fark.ToString();
                esayac = 0;

            }
            else if (csayac==1)
            {
                eleman2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";

                double carpm = eleman1*eleman2;
                textBox1.Text = carpm.ToString();
                csayac = 0;

            }
            else if (bsayac==1)
            {
                eleman2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";

                double carpm = eleman1/eleman2;
                textBox1.Text = carpm.ToString();
                bsayac = 0;

            }

            
        }

        private void eksi_Click(object sender, EventArgs e)
        {
            esayac++;

            if (esayac == 1)
            {
                eleman1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";
            }

        }

        private void carpi_Click(object sender, EventArgs e)
        {
            csayac++;

            if (csayac == 1)
            {
                eleman1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";
            }

        }

        private void bolu_Click(object sender, EventArgs e)
        {
            bsayac++;

            if (bsayac == 1)
            {
                eleman1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            double isaret =Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(isaret * (-1));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {

            }
            else
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }
    }
}
