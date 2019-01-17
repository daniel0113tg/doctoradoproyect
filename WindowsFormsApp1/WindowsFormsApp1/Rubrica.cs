using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Rubrica : Form
    {
        public Rubrica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value) +
                        Convert.ToInt32(numericUpDown2.Value) +
                        Convert.ToInt32(numericUpDown3.Value) +
                        Convert.ToInt32(numericUpDown4.Value) +
                        Convert.ToInt32(numericUpDown5.Value) +
                        Convert.ToInt32(numericUpDown6.Value) +
                        Convert.ToInt32(numericUpDown7.Value) +
                        Convert.ToInt32(numericUpDown8.Value) +
                        Convert.ToInt32(numericUpDown9.Value) +
                        Convert.ToInt32(numericUpDown10.Value) +
                        Convert.ToInt32(numericUpDown11.Value) +
                        Convert.ToInt32(numericUpDown12.Value) +
                        Convert.ToInt32(numericUpDown13.Value) +
                        Convert.ToInt32(numericUpDown14.Value) +
                        Convert.ToInt32(numericUpDown15.Value) +
                        Convert.ToInt32(numericUpDown16.Value) +
                        Convert.ToInt32(numericUpDown17.Value);

            label41.Text = Convert.ToString(count);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Principal p = new Principal();
            p.Show();
            this.Close();
        }
    }
}
