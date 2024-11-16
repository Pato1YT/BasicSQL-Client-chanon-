using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Basic_SQL_Client
{
    internal class Resaltado
    {
        private const string reservadas = @"\b(select|insert|into|update|table|create|database|use|delete|show|from|show|describe)\b";
        private const string funciones = @"\b(year|month|day)\b";
        private const string comentarios = @"(--.*$)";
        private const string cadenas = "'([^'\\\\]|\\\\.)*'|\"([^\"\\\\]|\\\\.)*\"";
        private Font fuenteOriginal = null;
        private Color colorOriginal = Color.Black;
        private RichTextBox editor;

        public Resaltado(RichTextBox editor)
        {
            this.editor = editor;
            colorOriginal = editor.ForeColor;
            fuenteOriginal = editor.Font;
        }

        private void aplicarFuente(MatchCollection coleccion,Color color,bool bold)
        {
            foreach (Match m in coleccion)
            {
                editor.SelectionStart = m.Index;
                editor.SelectionLength = m.Length;
                editor.SelectionColor = color;
                
                if(bold)
                editor.SelectionFont = new Font(fuenteOriginal, FontStyle.Bold);
            }
        }

        public void resaltar()
        {

            // posisiones y colores originales
            int originalIndex = editor.SelectionStart;
            int originalLength = editor.SelectionLength;
           
            //Clasifica los elementos
            MatchCollection reservadasMatches = Regex.Matches(editor.Text, reservadas);
            MatchCollection funcionesMatches = Regex.Matches(editor.Text, funciones);
            MatchCollection comentariosMatches = Regex.Matches(editor.Text, comentarios, RegexOptions.Multiline);
            MatchCollection cadenasMatches = Regex.Matches(editor.Text, cadenas);

            // Para que no se vea el parpadeo al escribir
            editor.Parent.Focus();

            // eliminamos colores que posiblemente se hayan colocado
            editor.SelectionStart = 0;
            editor.SelectionLength = editor.Text.Length;
            editor.SelectionColor = colorOriginal;
            editor.SelectionFont = fuenteOriginal;

            aplicarFuente(reservadasMatches, Color.Blue, true);
            aplicarFuente(funcionesMatches, Color.DarkCyan, false);
            aplicarFuente(comentariosMatches, Color.Green, false);
            aplicarFuente(cadenasMatches, Color.Brown, false);

            // restablecimiento de colores, fuente y posicion.
            editor.SelectionStart = originalIndex;
            editor.SelectionLength = originalLength;
            editor.SelectionColor = colorOriginal;
            editor.SelectionFont = fuenteOriginal;

            // regresamos enfoque para seguir escribiendo
            editor.Focus();
        }
    }
}
