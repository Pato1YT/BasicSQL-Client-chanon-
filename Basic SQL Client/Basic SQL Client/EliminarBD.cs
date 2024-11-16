using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_SQL_Client
{
    public partial class EliminarBD : Form
    {
        //Variable para la conexion a la base datos
        ConexionMySQL conexion;
        //Variable para hacer referencia a Principal.cs y hacer
        //uso de sus componentes y variables.
        Principal principal;
        //En el constructor recibe la referencia de la clase Principal.cs
        public EliminarBD(Principal principal)
        {
            InitializeComponent();
            //Nuestra variable local principal (this.principal)
            //recibe el valor de la referencia de Principal.cs.
            this.principal = principal;
            //Nuestra variable local conexion recibe el valor
            //de la conexión a la base de datos que esta en la
            //clase de Principal.cs.
            conexion = this.principal.conexion;
        }

        //METODO PARA CUANDO SE DA CLICK A "ELIMINAR BD"
        private void buttonEliminarBD_Click(object sender, EventArgs e)
        {
            //Se hace uso del método de ejecutarSQL que es el metodo que ejecuta las consultas SQL que se encuentra
            //en la clase ConexionMySQL.cs.
            /*
             * Este metodo recibe como argumentos:
             * 
             * SQL:
             * la consulta que espera en este caso: "drop database "+textBoxCrearBD.Text (ya que es eliminación), donde
             * textBoxCrearBD.Text es el texto que recibe donde se pide que se introduzca el nombre de la base de datos
             * a crear
             * 
             * principal.resultado:
             * Este es el componente Grid de la clase Principal.cs que tiene por nombre resultado, este se encarga de mostrar
             * en caso que sea necesario el valor que devuelve la consulta (las rows).
             * 
             * principal.consola:
             * Este es el componente RichTextBox consola de la clase Principal.cs que tiene por nombre consola, este se encarga
             * de mostrar por cada consulta ejecutada cuantas rows salieron afectadas.
             */
            conexion.ejecutarSQL("drop database " + textBoxEliminarBD.Text, principal.resultado, principal.consola);
            //Una vez que se ejecuta la consulta el formulario se esconde
            this.Hide();
        }
    }
}
