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
    public partial class Evaluacion : Form
    {
        public Evaluacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rubrica rubrica = new Rubrica();
            rubrica.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Principal prin = new Principal();
            prin.Show();
            this.Close();
        }
    }
}
