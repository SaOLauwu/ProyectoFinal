﻿namespace ProyectoFinal
{
    partial class frmLogin
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
            label1 = new Label();
            label2 = new Label();
            txtboxCi = new TextBox();
            txtboxPass = new TextBox();
            label3 = new Label();
            btnLogin = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 35F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 78);
            label1.TabIndex = 1;
            label1.Text = "Inicie sesión para continuar";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(186, 165);
            label2.Name = "label2";
            label2.Size = new Size(45, 32);
            label2.TabIndex = 2;
            label2.Text = "C.I.";
            // 
            // txtboxCi
            // 
            txtboxCi.Location = new Point(357, 174);
            txtboxCi.Name = "txtboxCi";
            txtboxCi.Size = new Size(276, 23);
            txtboxCi.TabIndex = 3;
            // 
            // txtboxPass
            // 
            txtboxPass.Location = new Point(357, 241);
            txtboxPass.Name = "txtboxPass";
            txtboxPass.PasswordChar = '*';
            txtboxPass.Size = new Size(276, 23);
            txtboxPass.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(97, 232);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(134, 32);
            label3.TabIndex = 4;
            label3.Text = "Contraseña";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(160, 357);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(186, 56);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Iniciar Sesión";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(393, 357);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(186, 56);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnSalir;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnSalir);
            Controls.Add(btnLogin);
            Controls.Add(txtboxPass);
            Controls.Add(label3);
            Controls.Add(txtboxCi);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLogin";
            Text = "frmLogin";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtboxPass;
        private Label label3;
        public Button btnLogin;
        public Button btnSalir;
        public TextBox txtboxCi;
    }
}