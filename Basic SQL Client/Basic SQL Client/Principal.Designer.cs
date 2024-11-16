namespace Basic_SQL_Client
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            editor = new RichTextBox();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            splitContainer2 = new SplitContainer();
            resultado = new DataGridView();
            consola = new RichTextBox();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            importarSQLToolStripMenuItem = new ToolStripMenuItem();
            exportarSQLToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resultado).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 35);
            splitContainer1.Margin = new Padding(4, 5, 4, 5);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(editor);
            splitContainer1.Panel1.Controls.Add(toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1399, 907);
            splitContainer1.SplitterDistance = 313;
            splitContainer1.SplitterWidth = 7;
            splitContainer1.TabIndex = 0;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // editor
            // 
            editor.BorderStyle = BorderStyle.FixedSingle;
            editor.Dock = DockStyle.Fill;
            editor.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editor.Location = new Point(0, 34);
            editor.Margin = new Padding(4, 5, 4, 5);
            editor.Name = "editor";
            editor.Size = new Size(1399, 279);
            editor.TabIndex = 1;
            editor.Text = "select * from usuario;";
            editor.TextChanged += editor_TextChanged;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripButton4 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 3, 0);
            toolStrip1.Size = new Size(1399, 34);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = Properties.Resources.run;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(101, 29);
            toolStripButton1.Text = "Ejecutar";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = Properties.Resources.historial;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(105, 29);
            toolStripButton2.Text = "Historial";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = Properties.Resources.crearBD;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(34, 29);
            toolStripButton3.Text = "toolStripButton3";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = Properties.Resources.eliminarBD;
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(34, 29);
            toolStripButton4.Text = "toolStripButton4";
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Margin = new Padding(4, 5, 4, 5);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(resultado);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(consola);
            splitContainer2.Size = new Size(1399, 587);
            splitContainer2.SplitterDistance = 418;
            splitContainer2.SplitterWidth = 7;
            splitContainer2.TabIndex = 0;
            // 
            // resultado
            // 
            resultado.AllowUserToAddRows = false;
            resultado.AllowUserToDeleteRows = false;
            resultado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultado.Dock = DockStyle.Fill;
            resultado.Location = new Point(0, 0);
            resultado.Margin = new Padding(4, 5, 4, 5);
            resultado.Name = "resultado";
            resultado.ReadOnly = true;
            resultado.RowHeadersWidth = 62;
            resultado.Size = new Size(1399, 418);
            resultado.TabIndex = 0;
            // 
            // consola
            // 
            consola.Dock = DockStyle.Fill;
            consola.Location = new Point(0, 0);
            consola.Margin = new Padding(4, 5, 4, 5);
            consola.Name = "consola";
            consola.Size = new Size(1399, 162);
            consola.TabIndex = 0;
            consola.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1399, 35);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importarSQLToolStripMenuItem, exportarSQLToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(88, 29);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // importarSQLToolStripMenuItem
            // 
            importarSQLToolStripMenuItem.Name = "importarSQLToolStripMenuItem";
            importarSQLToolStripMenuItem.Size = new Size(233, 34);
            importarSQLToolStripMenuItem.Text = "Importar SQL...";
            importarSQLToolStripMenuItem.Click += importarSQLToolStripMenuItem_Click;
            // 
            // exportarSQLToolStripMenuItem
            // 
            exportarSQLToolStripMenuItem.Name = "exportarSQLToolStripMenuItem";
            exportarSQLToolStripMenuItem.Size = new Size(233, 34);
            exportarSQLToolStripMenuItem.Text = "Exportar SQL...";
            exportarSQLToolStripMenuItem.Click += exportarSQLToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Archivos SQL (*.sql)|*.sql";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "Archivos SQL (*.sql)|*.sql";
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1399, 942);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Principal";
            Text = "Principal";
            FormClosing += Principal_FormClosing;
            Load += Principal_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)resultado).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer splitContainer1;
        private RichTextBox editor;
        private ToolStrip toolStrip1;
        private SplitContainer splitContainer2;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem importarSQLToolStripMenuItem;
        private ToolStripMenuItem exportarSQLToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripButton toolStripButton3;
        public RichTextBox consola;
        public DataGridView resultado;
        private ToolStripButton toolStripButton4;
    }
}
