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
    public partial class Form1 : Form
    {
        Models.Usuario usuario = new Models.Usuario();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Lenguajes len = new Lenguajes();
            //len.Show();
            if (txtContraseña.Text.Trim() == "" || txtUsuario.Text.Trim() == "")
                MessageBox.Show("Existen espacios vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (txtUsuario.Text == "Admin" && txtContraseña.Text == "1234")
                {
                    this.Hide();
                    Admin_Home conn = new Admin_Home();
                    conn.FormClosed += (s, args) => this.Close();
                    conn.Show();
                }
                else
                {
                    this.usuario.email = txtUsuario.Text.Trim();
                    this.usuario.clave = txtContraseña.Text.Trim();
                    DataSet resultado = usuario.Login(this.usuario);
                    if (resultado != null)
                    {
                        MessageBox.Show(resultado.Tables[0].Rows[0].ItemArray[1] + "");
                        if (resultado.Tables[0].Rows[0].ItemArray[0] + "" == "0")
                        {
                            this.Hide();
                            User_Home cn = new User_Home();
                            cn.datos = resultado.Tables[0];
                            cn.FormClosed += (s, args) => this.Close();
                            cn.Show();
                        }
                        else
                        {
                            MessageBox.Show("Email o clave incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email o clave incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registrar conn = new Registrar();
            conn.FormClosed += (s, args) => this.Close();
            conn.Show();
        }
    }
}
