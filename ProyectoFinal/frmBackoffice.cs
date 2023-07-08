using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class frmBackoffice : Form
    {
        public frmBackoffice()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            int ci;
            if (!int.TryParse(txtCedula.Text, out ci))
            {
                MessageBox.Show("El valor del campo Cedula debe ser numerico, sin guiones ni puntos.");
                return;
            }
            else
            {
                Program.altaUsuarios(ci, txtNombre.Text, txtPass.Text, cboRol.Text);
            }
        }
    }
}
