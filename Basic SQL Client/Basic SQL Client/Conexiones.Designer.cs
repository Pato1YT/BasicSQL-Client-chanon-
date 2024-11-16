namespace Basic_SQL_Client
{
    partial class Conexiones
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
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            cajaNombre = new TextBox();
            label6 = new Label();
            cajaPass = new TextBox();
            label5 = new Label();
            cajaBD = new TextBox();
            label4 = new Label();
            cajaUsuario = new TextBox();
            label3 = new Label();
            cajaServidor = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnNuevaConexion = new Button();
            btnEditar = new Button();
            btnBorrar = new Button();
            btnProbar = new Button();
            btnGuardar = new Button();
            btnConectar = new Button();
            label7 = new Label();
            btnCancelar = new Button();
            estado = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(148, 15);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(175, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cajaNombre);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cajaPass);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cajaBD);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cajaUsuario);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cajaServidor);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(384, 217);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de conexion";
            // 
            // cajaNombre
            // 
            cajaNombre.Enabled = false;
            cajaNombre.Location = new Point(99, 28);
            cajaNombre.Name = "cajaNombre";
            cajaNombre.Size = new Size(279, 23);
            cajaNombre.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 31);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 8;
            label6.Text = "Nombre:";
            // 
            // cajaPass
            // 
            cajaPass.Enabled = false;
            cajaPass.Location = new Point(99, 134);
            cajaPass.Name = "cajaPass";
            cajaPass.PasswordChar = '*';
            cajaPass.Size = new Size(279, 23);
            cajaPass.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 142);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 6;
            label5.Text = "Contraseña:";
            // 
            // cajaBD
            // 
            cajaBD.Enabled = false;
            cajaBD.Location = new Point(99, 172);
            cajaBD.Name = "cajaBD";
            cajaBD.Size = new Size(279, 23);
            cajaBD.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 173);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 4;
            label4.Text = "Base de datos:";
            // 
            // cajaUsuario
            // 
            cajaUsuario.Enabled = false;
            cajaUsuario.Location = new Point(99, 96);
            cajaUsuario.Name = "cajaUsuario";
            cajaUsuario.Size = new Size(279, 23);
            cajaUsuario.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 104);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 2;
            label3.Text = "Usuario:";
            // 
            // cajaServidor
            // 
            cajaServidor.Enabled = false;
            cajaServidor.Location = new Point(99, 61);
            cajaServidor.Name = "cajaServidor";
            cajaServidor.Size = new Size(279, 23);
            cajaServidor.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 66);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 0;
            label2.Text = "Servidor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 2;
            label1.Text = "Conexiones guardadas:";
            // 
            // btnNuevaConexion
            // 
            btnNuevaConexion.Location = new Point(12, 323);
            btnNuevaConexion.Name = "btnNuevaConexion";
            btnNuevaConexion.Size = new Size(112, 24);
            btnNuevaConexion.TabIndex = 5;
            btnNuevaConexion.Text = "&Nueva conexion";
            btnNuevaConexion.UseVisualStyleBackColor = true;
            btnNuevaConexion.Click += button1_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(320, 272);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(221, 272);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 3;
            btnBorrar.Text = "&Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnProbar
            // 
            btnProbar.Location = new Point(12, 272);
            btnProbar.Name = "btnProbar";
            btnProbar.Size = new Size(75, 23);
            btnProbar.TabIndex = 1;
            btnProbar.Text = "&Probar";
            btnProbar.UseVisualStyleBackColor = true;
            btnProbar.Click += btnProbar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(111, 272);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "&Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(148, 323);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(88, 23);
            btnConectar.TabIndex = 6;
            btnConectar.Text = "&Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // label7
            // 
            label7.BackColor = SystemColors.AppWorkspace;
            label7.Location = new Point(13, 310);
            label7.Name = "label7";
            label7.Size = new Size(383, 1);
            label7.TabIndex = 9;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(315, 324);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "C&ancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // estado
            // 
            estado.AutoEllipsis = true;
            estado.AutoSize = true;
            estado.BackColor = Color.Orange;
            estado.BorderStyle = BorderStyle.FixedSingle;
            estado.Location = new Point(363, 18);
            estado.Name = "estado";
            estado.Size = new Size(14, 17);
            estado.TabIndex = 11;
            estado.Text = "?";
            // 
            // Conexiones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 367);
            Controls.Add(estado);
            Controls.Add(btnCancelar);
            Controls.Add(label7);
            Controls.Add(btnConectar);
            Controls.Add(btnGuardar);
            Controls.Add(btnProbar);
            Controls.Add(btnBorrar);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevaConexion);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(comboBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Conexiones";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conexiones";
            TopMost = true;
            FormClosing += Conexiones_FormClosing;
            Load += Conexiones_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox cajaBD;
        private Label label4;
        private TextBox cajaUsuario;
        private Label label3;
        private TextBox cajaServidor;
        private Label label2;
        private Button btnNuevaConexion;
        private TextBox cajaPass;
        private Label label5;
        private Button btnEditar;
        private Button btnBorrar;
        private TextBox cajaNombre;
        private Label label6;
        private Button btnProbar;
        private Button btnGuardar;
        private Button btnConectar;
        private Label label7;
        private Button btnCancelar;
        private Label estado;
    }
}