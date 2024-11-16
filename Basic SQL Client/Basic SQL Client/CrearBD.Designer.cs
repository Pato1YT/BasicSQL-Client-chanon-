namespace Basic_SQL_Client
{
    partial class CrearBD
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
            label1 = new Label();
            label2 = new Label();
            textBoxCrearBD = new TextBox();
            buttonCrearBD = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 52);
            label1.Name = "label1";
            label1.Size = new Size(295, 38);
            label1.TabIndex = 0;
            label1.Text = "Crear Base de Datos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 139);
            label2.Name = "label2";
            label2.Size = new Size(204, 50);
            label2.TabIndex = 1;
            label2.Text = "Introduce el nombre de \r\nla base de datos:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxCrearBD
            // 
            textBoxCrearBD.Location = new Point(95, 221);
            textBoxCrearBD.Name = "textBoxCrearBD";
            textBoxCrearBD.Size = new Size(207, 31);
            textBoxCrearBD.TabIndex = 2;
            // 
            // buttonCrearBD
            // 
            buttonCrearBD.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonCrearBD.Location = new Point(140, 286);
            buttonCrearBD.Name = "buttonCrearBD";
            buttonCrearBD.Size = new Size(112, 34);
            buttonCrearBD.TabIndex = 3;
            buttonCrearBD.Text = "Crear BD";
            buttonCrearBD.UseVisualStyleBackColor = true;
            buttonCrearBD.Click += buttonCrearBD_Click;
            // 
            // CrearBD
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 450);
            Controls.Add(buttonCrearBD);
            Controls.Add(textBoxCrearBD);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CrearBD";
            Text = "CrearBD";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxCrearBD;
        private Button buttonCrearBD;
    }
}