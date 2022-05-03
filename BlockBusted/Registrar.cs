using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BlockBusted
{
    public partial class Registrar : Form
    {
        Models.Pelicula pel = new Models.Pelicula();
        public Registrar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!this.txtPassword.Text.Equals(this.txtConfirmPassword.Text))
            {
                MessageBox.Show("ERROR: Las contraseñas no coinciden");
            }
            else
            {
                pel.insertarUsuario(this.textBox1.Text,this.txtNickname.Text,this.txtPassword.Text,this.txtNombre.Text,this.txtApellido.Text,Convert.ToInt32(this.textBox2.Text.Trim()),this.txtDPI.Text);
            }
        }
    }
}
