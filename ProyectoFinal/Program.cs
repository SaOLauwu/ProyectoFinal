using ADODB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProyectoFinal
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        public static frmPrincipal principal = new frmPrincipal();
        public static ADODB.Connection cn = new ADODB.Connection();

        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();
            Application.Run(principal);

        }
        public static byte login(int ci, string password)
        {
            ADODB.Recordset rs = new ADODB.Recordset();
            Object filasAfectadas;
            String sql;
            String rol;
            if(cn.State != 0 )
            {
                sql= "SELECT RolId FROM usuarios WHERE ci =" + ci + " AND contraseña ='" + password + "'";
                
                try
                {
                    rs = cn.Execute(sql, out filasAfectadas);
                }
                catch
                {
                    MessageBox.Show("Existe un problema con la conexion al servidor. Intente nuevamente, si el problema persiste avise a un administrador");
                    return 2;
                }
                if (rs.RecordCount > 0 )
                {
                    rol = Convert.ToString(rs.Fields[0].Value);
                    switch (rol)
                    {
                        case "Camionero":
                            principal.btnHome.Visible = true;
                            principal.btnChoferes.Visible = true;
                            principal.btnConfiguracion.Visible = true;
                            principal.btnSalir.Visible = true;
                            principal.btnSeguimiento.Visible = true;
                            return 0;
                            
                        case "Almacenero":
                            principal.btnHome.Visible = true;
                            principal.btnConfiguracion.Visible = true;
                            principal.btnSalir.Visible = true;
                            principal.btnSeguimiento.Visible = true;
                            principal.btnAlmacenes.Visible = true;
                            return 0;

                        case "Administrativo":
                            principal.btnHome.Visible = true;
                            principal.btnConfiguracion.Visible = true;
                            principal.btnSalir.Visible = true;
                            principal.btnSeguimiento.Visible = true;
                            principal.btnAlmacenes.Visible = true;
                            principal.btnBackoffice.Visible = true;
                            principal.btnChoferes.Visible = true;
                            return 0;

                        default:
                            MessageBox.Show("Existe un error con el rol de este usuario. Avise a un administrador.");
                            return 2;
                            
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                    return 1;
                }
            }
            else
            {
                MessageBox.Show("Existe un problema con la conexion al servidor. Intente nuevamente, si el problema persiste avise a un administrador");
                return 2;
            }
        }

        public static void altaUsuarios(int ci, String nom, String pass, String rol)
        {
            ADODB.Recordset rs = new ADODB.Recordset();
            Object filasAfectadas;
            String sql;
            if (cn.State != 0)
            {
                sql = "select * from usuarios where ci =" + ci;
                try
                {
                    rs = cn.Execute(sql, out filasAfectadas);
                }
                catch
                {
                   MessageBox.Show("Existe un problema con la conexion al servidor. Intente nuevamente, si el problema persiste avise a un administrador");
                    return;
                }
                if (rs.RecordCount > 0)
                {
                    MessageBox.Show("Ya existe un usuario con esta cedula de identidad.");
                    return;
                }
                else
                {
                    sql = "insert into usuarios(ci,Nombre,Contraseña,RolId) VALUES (" + ci + ",'" + nom + "','" + pass + "','" + rol + "')";
                    try
                    {
                        rs = cn.Execute(sql, out filasAfectadas);
                    }
                    catch
                    {
                        MessageBox.Show("Existe un problema con la conexion al servidor. Intente nuevamente, si el problema persiste avise a un administrador");
                        return;
                    }
                    MessageBox.Show("Empleado ingresado con éxito.");
                }


            }
            else
            {
                MessageBox.Show("Existe un problema con la conexion al servidor. Intente nuevamente, si el problema persiste avise a un administrador");
                return;
            }

        }
        
    }
}