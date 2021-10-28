using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trafik_Işıkları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac=0;

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = sayac.ToString();

        }



        private void button1_Click(object sender, EventArgs e)
        {

            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            if (pictureBox1.Visible == true)
            {
                trafik.Start();
                if (trafik.Interval==300)
                {
                    MessageBox.Show("Test");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            trafik.Stop();
        }

        private void trafik_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text = sayac.ToString();

        }
    }
}
