using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Basic_SQL_Client
{
    public partial class Principal : Form
    {
        Resaltado r;
        //Se cambiar el modificador de acceso a público para la variable conexion
        //Para así, poder hacer uso de esta variable en las instancias que se realizan en
        //CrearBD.cs y EliminarBD.cs.
        public ConexionMySQL conexion;


        //NOTA IMPORTANTE: CAMBIAR EL MODIFICADOR DE ACCESO DEL Grif resultado y de
        //RichTextBox consola A PUBLICO PARA PODER HACER USO DE ESTOS DESDE OTRAS CLASES
        //(CrearBD.cs y EliminarBD.cs).
        
        public Principal()
        {
            InitializeComponent();
        }


        private void Principal_Load(object sender, EventArgs e)
        {
            r = new Resaltado(editor);
            r.resaltar();
            Conexiones con = new Conexiones();
            this.Hide();
            con.ShowDialog();
            //CONDICIONAR EL FORMULARIO HASTA OBTENER SATISFACTORIAMENTE UNA CONEXIÓN
            if (!con.cancelado)
            {
                conexion = new ConexionMySQL(con.cadenaConexionMySQL);
                this.Show();
            }

        }

        private void editor_TextChanged(object sender, EventArgs e)
        {
            r.resaltar();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            conexion.ejecutarSQL(editor.Text, resultado, consola);
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conexion != null)
                conexion.cerrarConexion();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Historial h = new Historial();
            h.ShowDialog();
        }

        private void importarSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                editor.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void exportarSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                editor.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        //ABRIR LA VENTANA DE CREAR BASES DE DATOS
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //Instancia de la clase de CrearBD.cs
            //A esta instancia se le pasa como argumento la referencia de la clase Principal
            //Se necesitara para hacer uso de componentes de la clase Principal (resultado, consola).
            CrearBD cBD = new CrearBD(this);
            //Se muestra el formulario.
            cBD.Show();
        }

        //ABRIR LA VENTANA DE ELIMINAR BASES DE DATOS
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //Instancia de la clase de EliminarBD.cs
            //A esta instancia se le pasa como argumento la referencia de la clase Principal
            //Se necesitara para hacer uso de componentes de la clase Principal (resultado, consola).
            EliminarBD eBD = new EliminarBD(this);
            //Se muestra el formulario.
            eBD.Show();
        }
    }
}
