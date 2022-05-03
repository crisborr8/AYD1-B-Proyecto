namespace BlockBusted
{
    partial class User_Home
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_Emal = new System.Windows.Forms.Label();
            this.btn_Ver = new System.Windows.Forms.Button();
            this.btn_Transferir = new System.Windows.Forms.Button();
            this.btn_Alquilar = new System.Windows.Forms.Button();
            this.btn_Retornar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-mail";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(34, 22);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(35, 13);
            this.lbl_Usuario.TabIndex = 2;
            this.lbl_Usuario.Text = "label3";
            // 
            // lbl_Emal
            // 
            this.lbl_Emal.AutoSize = true;
            this.lbl_Emal.Location = new System.Drawing.Point(37, 78);
            this.lbl_Emal.Name = "lbl_Emal";
            this.lbl_Emal.Size = new System.Drawing.Size(35, 13);
            this.lbl_Emal.TabIndex = 3;
            this.lbl_Emal.Text = "label3";
            // 
            // btn_Ver
            // 
            this.btn_Ver.Location = new System.Drawing.Point(164, 22);
            this.btn_Ver.Name = "btn_Ver";
            this.btn_Ver.Size = new System.Drawing.Size(196, 30);
            this.btn_Ver.TabIndex = 4;
            this.btn_Ver.Text = "Ver peliculas compradas";
            this.btn_Ver.UseVisualStyleBackColor = true;
            // 
            // btn_Transferir
            // 
            this.btn_Transferir.Location = new System.Drawing.Point(164, 78);
            this.btn_Transferir.Name = "btn_Transferir";
            this.btn_Transferir.Size = new System.Drawing.Size(196, 30);
            this.btn_Transferir.TabIndex = 5;
            this.btn_Transferir.Text = "Transferir peliculas";
            this.btn_Transferir.UseVisualStyleBackColor = true;
            // 
            // btn_Alquilar
            // 
            this.btn_Alquilar.Location = new System.Drawing.Point(164, 136);
            this.btn_Alquilar.Name = "btn_Alquilar";
            this.btn_Alquilar.Size = new System.Drawing.Size(196, 30);
            this.btn_Alquilar.TabIndex = 6;
            this.btn_Alquilar.Text = "Alquilar pelicula";
            this.btn_Alquilar.UseVisualStyleBackColor = true;
            this.btn_Alquilar.Click += new System.EventHandler(this.btn_Alquilar_Click);
            // 
            // btn_Retornar
            // 
            this.btn_Retornar.Location = new System.Drawing.Point(164, 194);
            this.btn_Retornar.Name = "btn_Retornar";
            this.btn_Retornar.Size = new System.Drawing.Size(196, 30);
            this.btn_Retornar.TabIndex = 7;
            this.btn_Retornar.Text = "Retornar pelicula";
            this.btn_Retornar.UseVisualStyleBackColor = true;
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(18, 136);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(109, 30);
            this.btn_Editar.TabIndex = 8;
            this.btn_Editar.Text = "Editar datos";
            this.btn_Editar.UseVisualStyleBackColor = true;
            // 
            // User_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 259);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Retornar);
            this.Controls.Add(this.btn_Alquilar);
            this.Controls.Add(this.btn_Transferir);
            this.Controls.Add(this.btn_Ver);
            this.Controls.Add(this.lbl_Emal);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "User_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User_Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lbl_Emal;
        private System.Windows.Forms.Button btn_Ver;
        private System.Windows.Forms.Button btn_Transferir;
        private System.Windows.Forms.Button btn_Alquilar;
        private System.Windows.Forms.Button btn_Retornar;
        private System.Windows.Forms.Button btn_Editar;
    }
}