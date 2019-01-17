using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESP
{
    public partial class Login : Form
    {
        private FlowLayoutPanel barraTitulo;
        private Panel panelPieDePagina;
        private Panel panelAutenticacion;
        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private TextBox textBox2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanel1;

        public Login()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.barraTitulo = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelPieDePagina = new System.Windows.Forms.Panel();
            this.panelAutenticacion = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelAutenticacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(1264, 30);
            this.barraTitulo.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 30);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1264, 135);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panelPieDePagina
            // 
            this.panelPieDePagina.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPieDePagina.BackgroundImage")));
            this.panelPieDePagina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPieDePagina.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPieDePagina.Location = new System.Drawing.Point(0, 619);
            this.panelPieDePagina.Name = "panelPieDePagina";
            this.panelPieDePagina.Size = new System.Drawing.Size(1264, 62);
            this.panelPieDePagina.TabIndex = 3;
            // 
            // panelAutenticacion
            // 
            this.panelAutenticacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelAutenticacion.BackgroundImage")));
            this.panelAutenticacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelAutenticacion.Controls.Add(this.button2);
            this.panelAutenticacion.Controls.Add(this.button1);
            this.panelAutenticacion.Controls.Add(this.panel4);
            this.panelAutenticacion.Controls.Add(this.panel3);
            this.panelAutenticacion.Controls.Add(this.panel2);
            this.panelAutenticacion.Controls.Add(this.textBox2);
            this.panelAutenticacion.Controls.Add(this.textBox1);
            this.panelAutenticacion.Controls.Add(this.comboBox1);
            this.panelAutenticacion.Location = new System.Drawing.Point(0, 165);
            this.panelAutenticacion.Name = "panelAutenticacion";
            this.panelAutenticacion.Size = new System.Drawing.Size(501, 454);
            this.panelAutenticacion.TabIndex = 4;
            this.panelAutenticacion.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAutenticacion_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(289, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 27);
            this.button2.TabIndex = 7;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Location = new System.Drawing.Point(135, 158);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(77, 27);
            this.panel4.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(135, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(77, 27);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(135, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(77, 38);
            this.panel2.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(209, 165);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(216, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(210, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 20);
            this.textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(209, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(498, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 454);
            this.panel1.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelAutenticacion);
            this.Controls.Add(this.panelPieDePagina);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.barraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelAutenticacion.ResumeLayout(false);
            this.panelAutenticacion.PerformLayout();
            this.ResumeLayout(false);

        }

        private void panelAutenticacion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowsFormsApp1.Principal princ = new WindowsFormsApp1.Principal();
            princ.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
