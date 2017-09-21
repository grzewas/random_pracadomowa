using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int liczba, reszka, orzel;
        Random rnd = new Random();
        int x;
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void czyśćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reszka = 0;
            orzel = 0;
            liczba = 0;
            label10.Text = "";
            label9.Text = "";
            label8.Text = "";
            label7.Text = "";
            label6.Text = "";
            label4.Text = "";
            textBox1.Text = "";
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void instrukcjaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBox1.Text) < 0)
                    textBox1.Text = "";

                if (int.Parse(textBox1.Text) > 21474836)
                    MessageBox.Show("Za długa liczba");
                
                liczba = 0;
                orzel = 0;
                reszka = 0;

                liczba = int.Parse(textBox1.Text);
                for (int i = 0; i < liczba; i++)
                {
                    x = rnd.Next(0, 2);
                    if (x == 0)
                        reszka += 1;
                    else
                        orzel += 1;
                }

                label4.Text = reszka.ToString();
                label6.Text = orzel.ToString();
                label7.Text = (100 * reszka / liczba).ToString();
                label8.Text = (100 - 100 * reszka / liczba).ToString();
                label9.Text = "%";
                label10.Text = "%";
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }


        }

        



       



    }
}
