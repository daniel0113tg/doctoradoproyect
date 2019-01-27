using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESP
{
    public partial class EstudianteForm : Form
    {
        String username;
        String nombrearchivo;
        String[] subirFormatoArray =new  String[3];
        ControladorEstudiante control;
        public EstudianteForm(String un,ControladorEstudiante control)
        {
            this.control = control;
            this.username = un;
            InitializeComponent();
            this.textBoxNomUsuario.Text = "pacari";
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr Mnd, int Vmsg, int nParam, int Iparam);

        private void restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            restaurar.Visible = false;
            maximizar.Visible = true;

        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            maximizar.Visible = false;
            restaurar.Visible = true;
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Seleccione Un archivo";
            openFileDialog1.ShowDialog();
            button1.Text = openFileDialog1.FileName;
        }

        private void btnSubirFormato_Click(object sender, EventArgs e)
        {
            subirFormatoArray[0] = nombreFormato.Text;
            subirFormatoArray[1] = tipoFormato.Text;
            subirFormatoArray[2] = openFileDialog1.FileName;
            control.enviaFormularioAEstudiante(subirFormatoArray);

        }
    }
}
