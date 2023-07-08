namespace ProyectoFinal
{
    partial class frmBackoffice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackoffice));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            txtCedula = new TextBox();
            txtPass = new TextBox();
            cboRol = new ComboBox();
            btnAlta = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 35F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(5, 9);
            label1.Name = "label1";
            label1.Size = new Size(775, 91);
            label1.TabIndex = 4;
            label1.Text = "Backoffice";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(261, 100);
            label2.Name = "label2";
            label2.Size = new Size(265, 72);
            label2.TabIndex = 5;
            label2.Text = "Agregar empleado";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(46, 192);
            label3.Name = "label3";
            label3.Size = new Size(265, 72);
            label3.TabIndex = 6;
            label3.Text = "Nombre:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(46, 264);
            label4.Name = "label4";
            label4.Size = new Size(265, 72);
            label4.TabIndex = 7;
            label4.Text = "Cedula:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(46, 336);
            label5.Name = "label5";
            label5.Size = new Size(265, 72);
            label5.TabIndex = 8;
            label5.Text = "Contraseña:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(46, 408);
            label6.Name = "label6";
            label6.Size = new Size(265, 72);
            label6.TabIndex = 9;
            label6.Text = "Rol:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(355, 222);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(274, 23);
            txtNombre.TabIndex = 10;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(355, 294);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(274, 23);
            txtCedula.TabIndex = 11;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(355, 366);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(274, 23);
            txtPass.TabIndex = 12;
            // 
            // cboRol
            // 
            cboRol.FormattingEnabled = true;
            cboRol.Items.AddRange(new object[] { "Administrativo", "Camionero", "Almacenero" });
            cboRol.Location = new Point(355, 438);
            cboRol.Name = "cboRol";
            cboRol.Size = new Size(274, 23);
            cboRol.TabIndex = 13;
            // 
            // btnAlta
            // 
            btnAlta.Location = new Point(310, 509);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(149, 57);
            btnAlta.TabIndex = 14;
            btnAlta.Text = "Alta";
            btnAlta.UseVisualStyleBackColor = true;
            btnAlta.Click += btnAlta_Click;
            // 
            // frmBackoffice
            // 
            AcceptButton = btnAlta;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(784, 620);
            Controls.Add(btnAlta);
            Controls.Add(cboRol);
            Controls.Add(txtPass);
            Controls.Add(txtCedula);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBackoffice";
            Text = "frmProveedores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNombre;
        private TextBox txtCedula;
        private TextBox txtPass;
        private ComboBox cboRol;
        private Button btnAlta;
    }
}