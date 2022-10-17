using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cwiki2AZ
{
    public partial class Form2 : Form
    {
        
        int b = 0;
        public Form2()
        {
            InitializeComponent();
            Form1.cena_komp = 0;

        }
        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString().Trim())
            {
               case "Windows 11" :

                    Form1.cena_komp = Form1.cena_komp + 300-b;
                    b = 300;
                    CENA2.Text = Form1.cena_komp.ToString() + "zł";
                    break;
                case "Windows 10":

                    Form1.cena_komp = Form1.cena_komp + 200 - b;
                    b = 200;
                    CENA2.Text = Form1.cena_komp.ToString() + "zł";
                    break;
                case "Linux":

                    Form1.cena_komp = Form1.cena_komp + 0 - b;
                    b = 0;
                    CENA2.Text = Form1.cena_komp.ToString() + "zł";
                    break;
                case "MacOS":

                    Form1.cena_komp = Form1.cena_komp + 666 - b;
                    b = 666;
                    CENA2.Text = Form1.cena_komp.ToString() + "zł";
                    break;
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Form1.cena_komp += 20;

            }
            if (checkBox1.Checked == false)
            {
                Form1.cena_komp -= 20;

            }
            CENA2.Text = Form1.cena_komp.ToString() + "zł";

        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                Form1.cena_komp += 150;

            }
            if (checkBox2.Checked == false)
            {
                Form1.cena_komp -= 150;

            }
            CENA2.Text = Form1.cena_komp.ToString() + "zł";
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                Form1.cena_komp += 375;

            }
            if (checkBox3.Checked == false)
            {
                Form1.cena_komp -= 375;

            }
            CENA2.Text = Form1.cena_komp.ToString() + "zł";
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                Form1.cena_komp += 35;

            }
            if (checkBox4.Checked == false)
            {
                Form1.cena_komp -= 35;

            }
            CENA2.Text = Form1.cena_komp.ToString() + "zł";
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                Form1.cena_komp += 50;

            }
            if (checkBox5.Checked == false)
            {
                Form1.cena_komp -= 50;

            }
            CENA2.Text = Form1.cena_komp.ToString() + "zł";
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                Form1.cena_komp += 333;
                
            }
            if(checkBox6.Checked==false)
            {
                Form1.cena_komp  -= 333;
                
            }
            CENA2.Text = Form1.cena_komp.ToString() + "zł";
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Form1.cena_komp += 50;
            }
            if (radioButton1.Checked == false)
            {
                Form1.cena_komp -= 50;
            }

            CENA2.Text = Form1.cena_komp.ToString() + "zł";
            
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Form1.cena_komp += 250;
            }
            if (radioButton2.Checked == false)
            {
                Form1.cena_komp -= 250;
            }
            CENA2.Text = Form1.cena_komp.ToString() + "zł";
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                Form1.cena_komp += 550;
            }
            if (radioButton3.Checked == false)
            {
                Form1.cena_komp -= 550;
            }
            CENA2.Text = Form1.cena_komp.ToString() + "zł";
        }

       
    }

}
