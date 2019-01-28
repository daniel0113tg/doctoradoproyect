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
        private String id_estudiante;
        private String[] subir_Formato;
        private String[] subir_Revista;
        private String[] subir_Conferencia;
        private ControladorEstudiante control;
        public EstudianteForm(String un)
        {
            InitializeComponent();
            this.id_estudiante = un;
            control = new ControladorEstudiante(id_estudiante);
            muestraEstudiante();
            muestraFormatos();
            //muestraRevistas();
            //muestraConferencias();
            this.WindowState = FormWindowState.Normal;
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
        private void muestraEstudiante()
        {
            String[] formularioEstudiante= control.obtenerDatosEstudiante();
            codigounico.Text = formularioEstudiante[0];
            cedula.Text = formularioEstudiante[1];
            nombres.Text = formularioEstudiante[2];
            apellidos.Text = formularioEstudiante[3];
            fechaNacimiento.Text = formularioEstudiante[4];
            CorreoE.Text = formularioEstudiante[5];
            Direccion.Text = formularioEstudiante[6];
            semestre.Text = formularioEstudiante[7];
            numMatricula.Text = formularioEstudiante[8];
        }
        private void muestraFormatos()
        {
            dataGridFormatos.DataSource = control.obtenerFormatos();
            dataGridFormatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

        }
        private void muestraRevistas()
        {
            dataGridRevista.DataSource = control.obtenerRevistas();
            dataGridRevista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
        private void muestraConferencias()
        {
            dataGridConferencias.DataSource = control.obtenerConferencias();
            dataGridConferencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
        public void recibeDatosPRevista()
        {
            subir_Revista = new String[12];
            subir_Revista[0] = "";
            subir_Revista[1] = "";
            subir_Revista[2] = "";
            subir_Revista[3] = "";
            subir_Revista[4] = "";
            subir_Revista[5] = "";
            subir_Revista[6] = "";
            subir_Revista[7] = "";
            subir_Revista[8] = "";
            subir_Revista[9] = "";
            subir_Revista[10] = "";
            subir_Revista[11] = "";
            control.enviadatosPRevista(subir_Revista);


        }
        public void recibeDatosPConferencia()
        {
            subir_Conferencia = new String[13];
            subir_Conferencia[0] = "";
            subir_Conferencia[1] = "";
            subir_Conferencia[2] = "";
            subir_Conferencia[3] = "";
            subir_Conferencia[4] = "";
            subir_Conferencia[5] = "";
            subir_Conferencia[6] = "";
            subir_Conferencia[7] = "";
            subir_Conferencia[8] = "";
            subir_Conferencia[9] = "";
            subir_Conferencia[10] = "";
            subir_Conferencia[11] = "";
            subir_Conferencia[12] = "";
            control.enviadatosPConferencia(subir_Conferencia);

        }
        public void recibeDatosFormato()
        {
            subir_Formato = new String[3];
            subir_Formato[0] = "";
            subir_Formato[1] = "";
            subir_Formato[2] = "";
            control.enviadatosPConferencia(subir_Formato);
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
            subirFormato.Title = "Seleccione Un archivo";
            subirFormato.ShowDialog();
        }

        private void btnSubirFormato_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            subirFormato.Filter = "PDF FILES | *.pdf";
            if (subirFormato.ShowDialog() == DialogResult.OK)
            {
                axAcroPDF1.src = subirFormato.FileName;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Revista")
            {
                dataGridConferencias.Visible = false;
                dataGridRevista.Visible = true;
            }
            else {
                if(comboBox3.Text == "Conferencia")
                {
                    dataGridRevista.Visible = false;
                    dataGridConferencias.Visible = true;

                } 
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            subir_Formato = new string[3];
            DateTime fecha = DateTime.Now;
            string dt1 = fecha.ToString("MM/dd/yyyy hh:mm");
            subir_Formato[0] = tipodeFormatoS.Text;
            subir_Formato[1] = dt1;
            subir_Formato[2] = subirFormato.FileName;
            control.enviadatosFormato(subir_Formato);
            muestraFormatos();
            subir_Formato = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
