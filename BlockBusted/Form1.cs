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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Lenguajes len = new Lenguajes();
            len.Show();
            if (txtContraseña.Text.Trim() == "" || txtUsuario.Text.Trim() == "")
                MessageBox.Show("Existen espacios vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.Hide();
                if (txtUsuario.Text == "Admin" && txtContraseña.Text == "1234")
                {
                    Admin_Home conn = new Admin_Home();
                    conn.FormClosed += (s, args) => this.Close();
                    conn.Show();
                }
                else
                {
                   // User_Home conn = new User_Home();
                   // conn.FormClosed += (s, args) => this.Close();
                    //conn.Show();

                    Alquiler cn = new Alquiler();
                    cn.FormClosed += (s, args) => this.Close();
                    cn.Show();

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
