namespace BlockBusted
{
    partial class Transferencia
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.cb_peliculas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Trasnferir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correo de amigo";
            // 
            // txt_Correo
            // 
            this.txt_Correo.Location = new System.Drawing.Point(15, 119);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(188, 20);
            this.txt_Correo.TabIndex = 1;
            // 
            // cb_peliculas
            // 
            this.cb_peliculas.FormattingEnabled = true;
            this.cb_peliculas.Location = new System.Drawing.Point(15, 43);
            this.cb_peliculas.Name = "cb_peliculas";
            this.cb_peliculas.Size = new System.Drawing.Size(358, 21);
            this.cb_peliculas.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pelicula a transferir";
            // 
            // btn_Trasnferir
            // 
            this.btn_Trasnferir.Location = new System.Drawing.Point(106, 172);
            this.btn_Trasnferir.Name = "btn_Trasnferir";
            this.btn_Trasnferir.Size = new System.Drawing.Size(188, 23);
            this.btn_Trasnferir.TabIndex = 4;
            this.btn_Trasnferir.Text = "Transferir";
            this.btn_Trasnferir.UseVisualStyleBackColor = true;
            this.btn_Trasnferir.Click += new System.EventHandler(this.btn_Trasnferir_Click);
            // 
            // Transferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 207);
            this.Controls.Add(this.btn_Trasnferir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_peliculas);
            this.Controls.Add(this.txt_Correo);
            this.Controls.Add(this.label1);
            this.Name = "Transferencia";
            this.Text = "Transferencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.ComboBox cb_peliculas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Trasnferir;
    }
}