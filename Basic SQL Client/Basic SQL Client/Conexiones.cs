using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.Data.Sqlite;
using System.Diagnostics;

namespace Basic_SQL_Client
{
    public partial class Conexiones : Form
    {
        private ConexionSQLite config;
        public bool cancelado = false; //para controlar el ingreso hasta asegurar que se conecta
        private bool editar = false; //para controlar al edición y creación de nuevas conexiones
        public Conexiones()
        {
            InitializeComponent();
            config = new ConexionSQLite();
        }

        public string cadenaConexionMySQL;

        private void button1_Click(object sender, EventArgs e)
        {
            cajaServidor.Enabled =
            cajaUsuario.Enabled =
            cajaBD.Enabled =
            cajaPass.Enabled =
            cajaNombre.Enabled = btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnBorrar.Enabled = false;
            cajaServidor.Clear();
            cajaUsuario.Clear();
            cajaBD.Clear();
            cajaPass.Clear();
            cajaNombre.Clear();
            comboBox1.SelectedIndex = -1;
            editar = false;
        }
        bool conexionCorrecta = false;
        private void btnProbar_Click(object sender, EventArgs e)
        {
            string cadenaConexion = ConexionMySQL.construirCadenaConexion(cajaServidor.Text, cajaUsuario.Text, cajaPass.Text, cajaBD.Text);

            MySqlConnection conexion = new MySqlConnection(cadenaConexion);

            try
            {
                conexion.Open();
                estado.Text = "OK";
                estado.BackColor = Color.Green;
                MessageBox.Show("La conexión se realizo satisfactoriamente");
                conexionCorrecta = true;
            }
            catch (MySqlException ex)
            {
                estado.Text = "NO";
                estado.BackColor = Color.Red;
                MessageBox.Show(ex.Message);
                conexionCorrecta = false;
            }
            finally
            {
                conexion.Close();
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (editar)
                config.actualizar(comboBox1.Text, cajaNombre.Text, cajaUsuario.Text, cajaPass.Text, cajaServidor.Text, cajaBD.Text);
            else
                config.guardar(cajaNombre.Text, cajaUsuario.Text, cajaPass.Text, cajaServidor.Text, cajaBD.Text);


            cajaServidor.Enabled =
            cajaUsuario.Enabled =
            cajaBD.Enabled =
            cajaPass.Enabled =
            cajaNombre.Enabled = btnGuardar.Enabled =
            btnEditar.Enabled =
            btnBorrar.Enabled = false;

            config.cargarConexiones(comboBox1);
        }

        private void Conexiones_Load(object sender, EventArgs e)
        {
            cajaServidor.Enabled =
            cajaUsuario.Enabled =
            cajaBD.Enabled =
            cajaPass.Enabled =
            cajaNombre.Enabled = btnGuardar.Enabled = btnBorrar.Enabled = btnEditar.Enabled = false;
            config.cargarConexiones(comboBox1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                Dictionary<string, string> con = config.conexiones[comboBox1.SelectedIndex];

                cajaNombre.Text = con.GetValueOrDefault("nombre");
                cajaServidor.Text = con.GetValueOrDefault("servidor");
                cajaUsuario.Text = con.GetValueOrDefault("usuario");
                cajaPass.Text = con.GetValueOrDefault("pass");
                cajaBD.Text = con.GetValueOrDefault("nombreBD");

                cajaServidor.Enabled =
                cajaUsuario.Enabled =
                cajaBD.Enabled =
                cajaPass.Enabled =
                cajaNombre.Enabled = btnGuardar.Enabled = false;
                btnEditar.Enabled = true;
                btnBorrar.Enabled = true;
            }
        }

        private void Conexiones_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Para reconoce si el usuario cierra el formulario manualmente en la X de la ventana o por Alt+F4
            
            if (!new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "Close"))
            {
                cancelado = true;
                Application.Exit();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelado = true;
            Application.Exit();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            cajaServidor.Enabled =
            cajaUsuario.Enabled =
            cajaBD.Enabled =
            cajaPass.Enabled =
            cajaNombre.Enabled = btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnBorrar.Enabled = false;
            editar = true;

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de eliminar la conexión?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                config.borrar(cajaNombre.Text);
                config.cargarConexiones(comboBox1);
                cajaServidor.Enabled =
                   cajaUsuario.Enabled =
                   cajaBD.Enabled =
                   cajaPass.Enabled =
                   cajaNombre.Enabled = btnGuardar.Enabled = btnBorrar.Enabled = false;
                cajaServidor.Clear();
                cajaUsuario.Clear();
                cajaBD.Clear();
                cajaPass.Clear();
                cajaNombre.Clear();
            }


        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            btnProbar_Click(sender, e);
            if (conexionCorrecta)
            {
                this.cadenaConexionMySQL = ConexionMySQL.construirCadenaConexion(cajaServidor.Text, cajaUsuario.Text, cajaPass.Text, cajaBD.Text);
                this.cancelado = false;
                this.Close();
            }
        }
    }
}
