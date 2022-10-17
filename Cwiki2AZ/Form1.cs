using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cwiki2AZ
{
    public partial class Form1 : Form
    {
        public static int cena_komp = 0;
        public static int cena_moni = 0;
        public Form1()
        {
            InitializeComponent();
   
        }

        private void label_komp_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form2 f2= new Form2();
            f2.ShowDialog();    
        }

        private void labelmonitor_Click(object sender, EventArgs e)
        {
            Form3 f3= new Form3();
            f3.ShowDialog(); 

        }

        private void labelkolor_Click(object sender, EventArgs e)
        {
            labelkolor.Text = (cena_komp+ cena_moni).ToString();
        }
    }
}
