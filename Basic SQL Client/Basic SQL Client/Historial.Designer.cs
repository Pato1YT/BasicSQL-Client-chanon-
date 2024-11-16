namespace Basic_SQL_Client
{
    partial class Historial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            fecha = new DataGridViewTextBoxColumn();
            conexion = new DataGridViewTextBoxColumn();
            instruccion = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            conexionSQLiteBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conexionSQLiteBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { fecha, conexion, instruccion, estado });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(800, 450);
            dataGridView1.TabIndex = 0;
            // 
            // fecha
            // 
            fecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            fecha.HeaderText = "Fecha";
            fecha.Name = "fecha";
            fecha.ReadOnly = true;
            fecha.Width = 63;
            // 
            // conexion
            // 
            conexion.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            conexion.HeaderText = "Conexion";
            conexion.Name = "conexion";
            conexion.ReadOnly = true;
            conexion.Width = 83;
            // 
            // instruccion
            // 
            instruccion.HeaderText = "Instruccion SQL";
            instruccion.MinimumWidth = 106;
            instruccion.Name = "instruccion";
            instruccion.ReadOnly = true;
            instruccion.Width = 500;
            // 
            // estado
            // 
            estado.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            estado.HeaderText = "Estado";
            estado.Name = "estado";
            estado.ReadOnly = true;
            estado.Width = 67;
            // 
            // conexionSQLiteBindingSource
            // 
            conexionSQLiteBindingSource.DataSource = typeof(ConexionSQLite);
            // 
            // Historial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Name = "Historial";
            Text = "Historial";
            Load += Historial_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)conexionSQLiteBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource conexionSQLiteBindingSource;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn conexion;
        private DataGridViewTextBoxColumn instruccion;
        private DataGridViewTextBoxColumn estado;
    }
}