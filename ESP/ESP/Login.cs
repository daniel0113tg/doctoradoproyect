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
    public partial class Login : Form
    {
        ControladorEstudiante control = new ControladorEstudiante();
        private String[] parametros = new String[3];
        private bool esperaparametros = true;
        private Panel panelPieDePagina;
        private Panel panelAutenticacion;
        private Panel Noticias;
        private Panel panelClave;
        private Panel panelUsuario;
        private Panel panelModo;
        private TextBox clave;
        private TextBox usuario;
        private ComboBox modo;
        private PictureBox ingresar;
        private Panel panelTitulo;
        private PictureBox restaurar;
        private PictureBox minimizar;
        private PictureBox maximizar;
        private PictureBox cerrar;
        private FlowLayoutPanel barraTitulo;
        private FlowLayoutPanel flowLayoutPanel1;

        public Login()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Noticias = new System.Windows.Forms.Panel();
            this.panelAutenticacion = new System.Windows.Forms.Panel();
            this.ingresar = new System.Windows.Forms.PictureBox();
            this.panelClave = new System.Windows.Forms.Panel();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.panelModo = new System.Windows.Forms.Panel();
            this.clave = new System.Windows.Forms.TextBox();
            this.usuario = new System.Windows.Forms.TextBox();
            this.modo = new System.Windows.Forms.ComboBox();
            this.panelPieDePagina = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.restaurar = new System.Windows.Forms.PictureBox();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.maximizar = new System.Windows.Forms.PictureBox();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.barraTitulo = new System.Windows.Forms.FlowLayoutPanel();
            this.panelAutenticacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingresar)).BeginInit();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            this.barraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Noticias
            // 
            this.Noticias.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Noticias.BackgroundImage = global::ESP.Properties.Resources._01_doctorado;
            this.Noticias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Noticias.Dock = System.Windows.Forms.DockStyle.Right;
            this.Noticias.Location = new System.Drawing.Point(498, 165);
            this.Noticias.Name = "Noticias";
            this.Noticias.Size = new System.Drawing.Size(766, 454);
            this.Noticias.TabIndex = 0;
            // 
            // panelAutenticacion
            // 
            this.panelAutenticacion.BackColor = System.Drawing.Color.Transparent;
            this.panelAutenticacion.BackgroundImage = global::ESP.Properties.Resources.login;
            this.panelAutenticacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelAutenticacion.Controls.Add(this.ingresar);
            this.panelAutenticacion.Controls.Add(this.panelClave);
            this.panelAutenticacion.Controls.Add(this.panelUsuario);
            this.panelAutenticacion.Controls.Add(this.panelModo);
            this.panelAutenticacion.Controls.Add(this.clave);
            this.panelAutenticacion.Controls.Add(this.usuario);
            this.panelAutenticacion.Controls.Add(this.modo);
            this.panelAutenticacion.Location = new System.Drawing.Point(0, 165);
            this.panelAutenticacion.Name = "panelAutenticacion";
            this.panelAutenticacion.Size = new System.Drawing.Size(501, 454);
            this.panelAutenticacion.TabIndex = 4;
            this.panelAutenticacion.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAutenticacion_Paint);
            // 
            // ingresar
            // 
            this.ingresar.BackColor = System.Drawing.Color.Transparent;
            this.ingresar.BackgroundImage = global::ESP.Properties.Resources.ingresarLoginPresionado1;
            this.ingresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ingresar.Location = new System.Drawing.Point(287, 209);
            this.ingresar.Name = "ingresar";
            this.ingresar.Size = new System.Drawing.Size(134, 35);
            this.ingresar.TabIndex = 6;
            this.ingresar.TabStop = false;
            this.ingresar.Click += new System.EventHandler(this.ingresar_Click);
            this.ingresar.MouseLeave += new System.EventHandler(this.ingresar_MouseLeave);
            this.ingresar.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // panelClave
            // 
            this.panelClave.BackColor = System.Drawing.Color.Transparent;
            this.panelClave.BackgroundImage = global::ESP.Properties.Resources.clave;
            this.panelClave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelClave.Location = new System.Drawing.Point(111, 141);
            this.panelClave.Name = "panelClave";
            this.panelClave.Size = new System.Drawing.Size(77, 56);
            this.panelClave.TabIndex = 5;
            // 
            // panelUsuario
            // 
            this.panelUsuario.BackColor = System.Drawing.Color.Transparent;
            this.panelUsuario.BackgroundImage = global::ESP.Properties.Resources.usuario;
            this.panelUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelUsuario.Location = new System.Drawing.Point(111, 101);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(77, 51);
            this.panelUsuario.TabIndex = 4;
            // 
            // panelModo
            // 
            this.panelModo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelModo.BackColor = System.Drawing.Color.Transparent;
            this.panelModo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelModo.BackgroundImage")));
            this.panelModo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelModo.Location = new System.Drawing.Point(108, 57);
            this.panelModo.Name = "panelModo";
            this.panelModo.Size = new System.Drawing.Size(80, 52);
            this.panelModo.TabIndex = 3;
            // 
            // clave
            // 
            this.clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clave.Location = new System.Drawing.Point(185, 158);
            this.clave.Name = "clave";
            this.clave.PasswordChar = '•';
            this.clave.Size = new System.Drawing.Size(210, 21);
            this.clave.TabIndex = 2;
            // 
            // usuario
            // 
            this.usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.Location = new System.Drawing.Point(185, 115);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(210, 21);
            this.usuario.TabIndex = 1;
            // 
            // modo
            // 
            this.modo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.modo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modo.FormattingEnabled = true;
            this.modo.Items.AddRange(new object[] {
            "ESTUDIANTE",
            "PROFESOR",
            "COORDINADOR",
            "DIRECTOR"});
            this.modo.Location = new System.Drawing.Point(185, 72);
            this.modo.Name = "modo";
            this.modo.Size = new System.Drawing.Size(210, 23);
            this.modo.TabIndex = 0;
            // 
            // panelPieDePagina
            // 
            this.panelPieDePagina.BackgroundImage = global::ESP.Properties.Resources.pie;
            this.panelPieDePagina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPieDePagina.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPieDePagina.Location = new System.Drawing.Point(0, 619);
            this.panelPieDePagina.Name = "panelPieDePagina";
            this.panelPieDePagina.Size = new System.Drawing.Size(1264, 62);
            this.panelPieDePagina.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = global::ESP.Properties.Resources.titulo;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 30);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1264, 135);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTitulo.Controls.Add(this.restaurar);
            this.panelTitulo.Controls.Add(this.minimizar);
            this.panelTitulo.Controls.Add(this.maximizar);
            this.panelTitulo.Controls.Add(this.cerrar);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(3, 3);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1264, 27);
            this.panelTitulo.TabIndex = 8;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // restaurar
            // 
            this.restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restaurar.Image = ((System.Drawing.Image)(resources.GetObject("restaurar.Image")));
            this.restaurar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.restaurar.Location = new System.Drawing.Point(1187, 8);
            this.restaurar.Name = "restaurar";
            this.restaurar.Size = new System.Drawing.Size(25, 13);
            this.restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.restaurar.TabIndex = 3;
            this.restaurar.TabStop = false;
            this.restaurar.Visible = false;
            this.restaurar.Click += new System.EventHandler(this.restaurar_Click);
            // 
            // minimizar
            // 
            this.minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.minimizar.Location = new System.Drawing.Point(1144, 8);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(25, 16);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizar.TabIndex = 2;
            this.minimizar.TabStop = false;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click_1);
            // 
            // maximizar
            // 
            this.maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizar.Image = ((System.Drawing.Image)(resources.GetObject("maximizar.Image")));
            this.maximizar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.maximizar.Location = new System.Drawing.Point(1187, 8);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(25, 13);
            this.maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximizar.TabIndex = 1;
            this.maximizar.TabStop = false;
            this.maximizar.Click += new System.EventHandler(this.maximizar_Click);
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cerrar.Location = new System.Drawing.Point(1227, 8);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(25, 13);
            this.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrar.TabIndex = 0;
            this.cerrar.TabStop = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.barraTitulo.Controls.Add(this.panelTitulo);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(1264, 30);
            this.barraTitulo.TabIndex = 2;
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Noticias);
            this.Controls.Add(this.panelAutenticacion);
            this.Controls.Add(this.panelPieDePagina);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.barraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelAutenticacion.ResumeLayout(false);
            this.panelAutenticacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingresar)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            this.barraTitulo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void panelAutenticacion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            ingresar.Image= global::ESP.Properties.Resources.ingresarLoginPresionado;
        }

        private void ingresar_MouseLeave(object sender, EventArgs e)
        {
            ingresar.Image = global::ESP.Properties.Resources.ingresarLogin;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr Mnd, int Vmsg, int nParam, int Iparam);

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        public String[] getParametros()
        {
            return parametros;
        }
        public bool esperaParametros()
        {
            return esperaparametros;
        }

        private void maximizar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            //maximizar.Visible = false;
            //restaurar.Visible = true;
        }


        private void restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            restaurar.Visible = false;
            maximizar.Visible = true;
        }

        private void minimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            if (modo.SelectedIndex !=-1)
            {
                parametros[0] = modo.Text;
                parametros[1] = usuario.Text;
                parametros[2] = clave.Text;
                if (control.iniciarSesion(parametros))
                {
                    this.Hide();
                    control.abrirFormRol();
                }
            }
            else
            {
                // MessageBox.Show("POR FAVOR SELECCIONE UN MODO",}"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                MessageBox.Show(" POR FAVOR SELECCIONE UN MODO PRIMERO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public ControladorEstudiante getControl()
        {
            return control;
        }
    }
}
