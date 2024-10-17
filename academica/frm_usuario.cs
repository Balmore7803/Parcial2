using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace academica
{

    // Juan Ramon Torres Guzman 
    //Jose Balmore Rodriguez Muñoz
    public partial class frm_usuario : Form
    {
        Conexion objConexion = new Conexion();
        DataSet ds = new DataSet();
        DataTable miTabla = new DataTable();

        public int posicion = 0;
        String accion = "nuevo";
        public frm_usuario()
        {
            InitializeComponent();
        }

        private void frm_usuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_db_academicaDataSet1.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter1.Fill(this._db_academicaDataSet1.usuarios);


            actualizarDs();
        }
        private void actualizarDs()
        {
            ds.Clear();
            ds = objConexion.obtenerDatos();
            miTabla = ds.Tables["usuarios"];
            miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns["idUsuario"] };
            grdDatosUsuarios.DataSource = miTabla;
            mostrarDatosUsuarios();
        }
        private void mostrarDatosUsuarios()
        {
            if (miTabla.Rows.Count > 0)
            {
                txtUsuarioUsuarios.Text = miTabla.Rows[posicion].ItemArray[1].ToString();
                txtClaveUsuarios.Text = miTabla.Rows[posicion].ItemArray[2].ToString();
                txtNombreUsuarios.Text = miTabla.Rows[posicion].ItemArray[3].ToString();
                txtDireccionUsuarios.Text = miTabla.Rows[posicion].ItemArray[4].ToString();
                txtTelefonoUsuarios.Text = miTabla.Rows[posicion].ItemArray[5].ToString();

                lblRegistrosUsuarios.Text = (posicion + 1) + " de " + miTabla.Rows.Count;
            }
        }

        private void btnSiguienteUsuarios_Click(object sender, EventArgs e)
        {
            if (posicion < miTabla.Rows.Count - 1)
            {
                posicion++;
                mostrarDatosUsuarios();
            }
            else
            {
                MessageBox.Show("Esta en el ultimo registro", "Navegacion de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnteriorUsuarios_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatosUsuarios();
            }
            else
            {
                MessageBox.Show("Esta en el primer registro", "Navegacion de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimoUsuarios_Click(object sender, EventArgs e)
        {
            posicion = miTabla.Rows.Count - 1;
            mostrarDatosUsuarios();
        }

        private void btnPrimeroUsuarios_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatosUsuarios();
        }

        private void estadoControles(Boolean estado)
        {
            grbDatosUsuarios.Enabled = estado;
            grbNavegacionUsuarios.Enabled = !estado;
            btnEliminarUsuarios.Enabled = !estado;
        }

        private void btnNuevoUsuarios_Click(object sender, EventArgs e)
        {
            if (btnNuevoUsuarios.Text == "Nuevo")
            {
                btnNuevoUsuarios.Text = "Guardar";
                btnModificarUsuarios.Text = "Cancelar";
                accion = "nuevo";
                estadoControles(true);
                limpiarCajas();
            }
            else
            {//Guardar
                String[] usuarios = {
                    accion, miTabla.Rows[posicion].ItemArray[0].ToString(),
                    txtUsuarioUsuarios.Text, txtClaveUsuarios.Text, txtNombreUsuarios.Text, txtDireccionUsuarios.Text, txtTelefonoUsuarios.Text
            };
                String respuesta = objConexion.mantenimiento_usuarios(usuarios);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error en el registro de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    btnNuevoUsuarios.Text = "Nuevo";
                    btnModificarUsuarios.Text = "Modificar";
                    estadoControles(false);
                    actualizarDs();
                }
              
            }
        }

        void limpiarCajas()
        {
            txtUsuarioUsuarios.Text = "";
            txtClaveUsuarios.Text = "";
            txtNombreUsuarios.Text = "";
            txtDireccionUsuarios.Text = "";
            txtTelefonoUsuarios.Text = "";

        }

        private void btnModificarUsuarios_Click(object sender, EventArgs e)
        {
            if (btnModificarUsuarios.Text == "Modificar")
            {
                btnNuevoUsuarios.Text = "Guardar";
                btnModificarUsuarios.Text = "Cancelar";
                accion = "modificar";
                estadoControles(true);
            }
            else
            {//Cancelar
                mostrarDatosUsuarios();
                btnNuevoUsuarios.Text = "Nuevo";
                btnModificarUsuarios.Text = "Modificar";
                estadoControles(false);
            }
      
        
        }

        private void btnEliminarUsuarios_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombreUsuarios.Text.Trim() + "?", "Eliminar usuarios", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String[] usuarios = {
                    "eliminar", miTabla.Rows[posicion].ItemArray[0].ToString()
                };
                String respuesta = objConexion.mantenimiento_usuarios(usuarios);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error en el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    actualizarDs();
                    mostrarDatosUsuarios();
                }
            }
        }
        private void filtrarDatos(string filtro)
        {
            // Verificar que el filtro no esté vacío
            if (string.IsNullOrWhiteSpace(filtro))
            {
                // Si el filtro está vacío, restablecer el filtro a mostrar todos los registros
                miTabla.DefaultView.RowFilter = string.Empty; // Esto mostrará todos los registros
            }
            else
            {
                DataView dv = miTabla.DefaultView;
                dv.RowFilter = "usuario LIKE '%" + filtro + "%' OR nombre LIKE '%" + filtro + "%'";
                grdDatosUsuarios.DataSource = dv;
            }
        }

        private void seleccionarUsuarios()
        {
            if (grdDatosUsuarios.CurrentRow != null)
            {
                try
                {
                    string idUsuarioString = grdDatosUsuarios.CurrentRow.Cells["idUsuario"].Value.ToString().Trim();

                    // Verificar que el idUsuario no esté vacío
                    if (string.IsNullOrEmpty(idUsuarioString))
                    {
                        // Ignorar si idUsuario está vacío
                        return;
                    }

                    // Buscar el registro en la tabla
                    posicion = miTabla.Rows.IndexOf(miTabla.Rows.Find(idUsuarioString));

                    // Solo llamar a mostrarDatosUsuarios si se encontró el registro
                    if (posicion != -1)
                    {
                        mostrarDatosUsuarios();
                    }
                }
                catch (Exception)
                {
                    // Se ignoran los errores sin hacer nada
                }
            }
            else
            {
                // Aquí puedes ignorar o manejar el caso donde no hay una fila seleccionada
            }
        }




        private void txtBuscarUsuarios_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarDatos(txtBuscarUsuarios.Text);
            seleccionarUsuarios();
        }
    }
}





            
          
              
                
                
                   

                 
                  
