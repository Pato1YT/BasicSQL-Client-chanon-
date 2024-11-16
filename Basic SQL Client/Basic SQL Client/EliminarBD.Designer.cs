namespace Basic_SQL_Client
{
    partial class EliminarBD
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
            buttonEliminarBD = new Button();
            textBoxEliminarBD = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonEliminarBD
            // 
            buttonEliminarBD.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonEliminarBD.Location = new Point(135, 284);
            buttonEliminarBD.Name = "buttonEliminarBD";
            buttonEliminarBD.Size = new Size(121, 34);
            buttonEliminarBD.TabIndex = 7;
            buttonEliminarBD.Text = "Eliminar BD";
            buttonEliminarBD.UseVisualStyleBackColor = true;
            buttonEliminarBD.Click += buttonEliminarBD_Click;
            // 
            // textBoxEliminarBD
            // 
            textBoxEliminarBD.Location = new Point(91, 219);
            textBoxEliminarBD.Name = "textBoxEliminarBD";
            textBoxEliminarBD.Size = new Size(207, 31);
            textBoxEliminarBD.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 137);
            label2.Name = "label2";
            label2.Size = new Size(204, 50);
            label2.TabIndex = 5;
            label2.Text = "Introduce el nombre de \r\nla base de datos:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 50);
            label1.Name = "label1";
            label1.Size = new Size(336, 38);
            label1.TabIndex = 4;
            label1.Text = "Eliminar Base de Datos";
            // 
            // EliminarBD
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 453);
            Controls.Add(buttonEliminarBD);
            Controls.Add(textBoxEliminarBD);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EliminarBD";
            Text = "EliminarBD";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEliminarBD;
        private TextBox textBoxEliminarBD;
        private Label label2;
        private Label label1;
    }
}