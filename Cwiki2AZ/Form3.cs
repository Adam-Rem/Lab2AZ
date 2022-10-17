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
    public partial class Form3 : Form
    {
        int b = 0;
        int c = 0;
        public Form3()
        {
            InitializeComponent();
            Form1.cena_moni = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Form1.cena_moni += 200 - b;
                    b = 200;
                    label1.Text = Form1.cena_moni.ToString() + "zł";
                    break;
                case 1:
                    Form1.cena_moni += 300 - b;
                    b = 300;
                    label1.Text = Form1.cena_moni.ToString() + "zł";
                    break;
                case 2:
                    Form1.cena_moni += 220 - b;
                    b = 220;
                    label1.Text = Form1.cena_moni.ToString() + "zł";
                    break;
                case 3:
                    Form1.cena_moni += 100 - b;
                    b = 100;
                    label1.Text = Form1.cena_moni.ToString() + "zł";
                    break;
                case 4:
                    Form1.cena_moni += 345 - b;
                    b = 345;
                    label1.Text = Form1.cena_moni.ToString() + "zł";
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox2.SelectedIndex)
            { 
                case 0:
                Form1.cena_moni += 200 - c;
                c = 200;
                label1.Text = Form1.cena_moni.ToString() + "zł" ;
                break;
            case 1:
                Form1.cena_moni += 300 - c;
                c = 300;
                label1.Text = Form1.cena_moni.ToString() + "zł";
                break;
            case 2:
                Form1.cena_moni += 400 - c;
                c = 400;
                label1.Text = Form1.cena_moni.ToString() + "zł";
                break;
            case 3:
                Form1.cena_moni += 500 - c;
                c = 500;
                label1.Text = Form1.cena_moni.ToString() + "zł";
                break;
            }

        }
    }
}
