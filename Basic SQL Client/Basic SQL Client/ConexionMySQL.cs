using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_SQL_Client
{

 

    public class ConexionMySQL
    {
        private string cadenaConexion;
        MySqlConnection conexion;
        //Esta es una cadena de conexion de EJEMPLO.
        //private string cadenaConexion = "Server=127.0.0.1;Port=3307;Database=tienda;Uid=root;Pwd=admin";
        public static string construirCadenaConexion(string servidor,string usuario,string pass,string bd) 
        {
            string temp;
            if(bd==null) { 
                //Se le agrego a la cadena de conexión el apartado del puerto por si llega a ser otro que no sea el por
                //Defaul (3306).
                //SI TU PUERTO ES DIFERENTE CAMBIARLO POR EL TUYO
                temp = "Server=" + servidor + ";User ID=" + usuario + ";Password=" + pass + ";Port=3307";
            }
            else {
                //Se le agrego a la cadena de conexión el apartado del puerto por si llega a ser otro que no sea el por
                //Defaul (3306).
                //SI TU PUERTO ES DIFERENTE CAMBIARLO POR EL TUYO
                temp = "Server=" + servidor + ";User ID=" + usuario + ";Password=" + pass + ";Database=" + bd + ";Port=3307";
            }
            return temp;

        }
        public ConexionMySQL(string cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
            conexion = new MySqlConnection(this.cadenaConexion);
            conexion.Open();//Se mantiene la conexión abierta
        }


        public int ejecutarSQL(string SQL,System.Windows.Forms.DataGridView grid,System.Windows.Forms.RichTextBox consola)
        {
            int res = 0;
            SQL = SQL.Trim();
            try{
                if (SQL.StartsWith("select") || SQL.StartsWith("show") || SQL.StartsWith("describe"))
                {

                    MySqlDataAdapter adaptador = new MySqlDataAdapter(SQL, this.conexion);

                    System.Data.DataSet tempRec = new System.Data.DataSet();
                    adaptador.Fill(tempRec);
                    if (tempRec.Tables.Count > 0)
                    {
                        grid.DataSource = tempRec.Tables[0];
                    }

                    res = 0;
                }
                else
                {
                    grid.DataSource = null;
                    MySqlCommand comando = new MySqlCommand(SQL,this.conexion);
                    res = comando.ExecuteNonQuery();
                }
                ConexionSQLite lite = new ConexionSQLite();
                lite.guardarHistorial("demo", SQL, "SATISFACTORIO");
                consola.Text += "\n La instruccion ejecutada correctamente. Registros afectados: " + res;
            }
            catch(MySqlException ex)
            {
                res = -1;
                ConexionSQLite lite = new ConexionSQLite();
                String saltoLinea = Environment.NewLine;
                lite.guardarHistorial("demo", SQL+saltoLinea+" CAUSA: "+ex.Message, "FALLO");
                consola.Text += "\n La instruccion no pudo ser ejecutada: " + ex.Message;
            }
            finally
            {
                consola.SelectionStart = consola.Text.Length;
                consola.ScrollToCaret();
            }

            return res;
        }

        public void cerrarConexion()
        {
             if(this.conexion.State == System.Data.ConnectionState.Open)
            {
                this.conexion.Close();
            }
             
        }

     

    }
}
