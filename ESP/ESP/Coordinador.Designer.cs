namespace ESP
{
    partial class Coordinador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.coordinadorPage = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.requisitos = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.coordinadorPage.SuspendLayout();
            this.requisitos.SuspendLayout();
            this.SuspendLayout();
            // 
            // coordinadorPage
            // 
            this.coordinadorPage.Controls.Add(this.tabPage1);
            this.coordinadorPage.Controls.Add(this.requisitos);
            this.coordinadorPage.Controls.Add(this.tabPage3);
            this.coordinadorPage.Location = new System.Drawing.Point(12, 12);
            this.coordinadorPage.Name = "coordinadorPage";
            this.coordinadorPage.SelectedIndex = 0;
            this.coordinadorPage.Size = new System.Drawing.Size(828, 471);
            this.coordinadorPage.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(820, 445);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Asignación";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // requisitos
            // 
            this.requisitos.Controls.Add(this.label2);
            this.requisitos.Location = new System.Drawing.Point(4, 22);
            this.requisitos.Name = "requisitos";
            this.requisitos.Padding = new System.Windows.Forms.Padding(3);
            this.requisitos.Size = new System.Drawing.Size(820, 445);
            this.requisitos.TabIndex = 1;
            this.requisitos.Text = "Requisitos";
            this.requisitos.UseVisualStyleBackColor = true;
            this.requisitos.Click += new System.EventHandler(this.requisitos_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(820, 445);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reportes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID estudiante";
            // 
            // Coordinador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 495);
            this.Controls.Add(this.coordinadorPage);
            this.Name = "Coordinador";
            this.Text = "Coordinador";
            this.coordinadorPage.ResumeLayout(false);
            this.requisitos.ResumeLayout(false);
            this.requisitos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl coordinadorPage;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage requisitos;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
    }
}