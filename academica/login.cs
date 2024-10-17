using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 
using System.Windows.Forms;


namespace academica
{
    public partial class login : Form
    {
        private Conexion conexion; // Instancia de la clase Conexion

        public login()
        {
            InitializeComponent();
            conexion = new Conexion(); // Inicializar la conexión
        }

        

        private bool AutenticarUsuario(string nombreUsuario, string contraseña)
        {
            // Se utiliza un DataSet para obtener datos de la tabla de usuarios
            DataSet ds = conexion.obtenerDatos();
            DataTable usuarios = ds.Tables["usuarios"];

            // Busca si el usuario existe en el DataTable
            foreach (DataRow row in usuarios.Rows)
            {
                if (row["usuario"].ToString() == nombreUsuario && row["clave"].ToString() == contraseña)
                {
                    return true; // Retorna true si las credenciales son correctas
                }
            }
            return false; // Retorna false si no se encontró coincidencia
        }

        private void btnIngresarLogin_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreLogin.Text;
            string contraseña = txtContraseñaLogin.Text;

            if (AutenticarUsuario(nombreUsuario, contraseña))
            {
                MessageBox.Show("¡Inicio de sesión exitoso!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Crear una instancia del formulario principal
                principal mainForm = new principal(); 
                this.Hide(); // Oculta el formulario de inicio de sesión
                mainForm.Show(); // Muestra el formulario principal
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

