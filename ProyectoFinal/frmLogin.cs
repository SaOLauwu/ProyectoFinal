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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int ci;
            String pass = txtboxPass.Text;
            if (!int.TryParse(txtboxCi.Text, out ci))
            {
                MessageBox.Show("El valor ingresado debe ser numerico, sin puntos ni guiones.");
                return;
            }
            else
            {
                switch (Program.login(ci, pass))
                {
                    case 0:
                        this.Close();
                        break;
                    case 1:
                        return;
                    case 2:
                        return;
                }

            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                Program.cn.Open("odbcproy", "admin", "admin");
            }
            catch
            {
                MessageBox.Show("Existe un error con la conexion al servidor. Avise al administrador del programa.");
            }
            Program.cn.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
