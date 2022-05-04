using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockBusted.Models
{
    public partial class Usuarios : Form
    {
        Usuario cl = new Usuario();

        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            this.cargarDatos();
        }

        private void cargarDatos()
        {
            cl.email = "";
            cl.nombre = "";
            cl.apellido = "";
            cl.alias = "";
            cl.dpi = "";
            cl.clave = "";
            cl.edad = "";

            DataSet datos = cl.consulta();

            if (datos != null)
            {
                DataTable dt = new DataTable();
                dt = datos.Tables[0];
                this.usuarioBindingSource.DataSource = dt;
                this.usuarioDataGridView.DataSource = this.usuarioBindingSource;
            }
            else
            {
                List<Usuario> list = new List<Usuario>();
                this.usuarioBindingSource.DataSource = list;
                this.usuarioDataGridView.DataSource = this.usuarioBindingSource;
            }

        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            this.emailTextBox.Text = "";
            this.nombreTextBox.Text = "";
            this.apellidoTextBox.Text = "";
            this.aliasTextBox.Text = "";
            this.dpiTextBox.Text = "";
            this.edadTextBox.Text = "";
            this.claveTextBox.Text = "";

            this.emailTextBox.Enabled = true;
            this.emailTextBox.Focus();
        }

        private void guardar_Click(object sender, EventArgs e)
        {

            this.AgregarUsuario();
            this.cargarDatos();

        }

        public void GuardarUsuario()
        {
            try
            {
                this.cl.email = this.emailTextBox.Text.Trim();
                this.cl.nombre = this.nombreTextBox.Text.Trim();
                this.cl.apellido = this.apellidoTextBox.Text.Trim();
                this.cl.clave = this.claveTextBox.Text.Trim();
                this.cl.dpi = this.dpiTextBox.Text.Trim();
                this.cl.edad = this.edadTextBox.Text.Trim();
                this.cl.alias = this.aliasTextBox.Text.Trim();


                int resultado = 0;

                if (this.cl.email != "") // Insertar
                {
                    resultado = cl.Update(this.cl);
                    this.cargarDatos();

                }
                else
                {
                    MessageBox.Show("Error al crear cuenta");
                }

                if (resultado == 1)
                {
                    MessageBox.Show("Cliente guardado correctamente", "Exito", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Error al guardar cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AgregarUsuario()
        {
            try
            {
                this.cl.email = this.emailTextBox.Text.Trim();
                this.cl.nombre = this.nombreTextBox.Text.Trim();
                this.cl.apellido = this.apellidoTextBox.Text.Trim();
                this.cl.clave = this.claveTextBox.Text.Trim();
                this.cl.dpi = this.dpiTextBox.Text.Trim();
                this.cl.edad = this.edadTextBox.Text.Trim();
                this.cl.alias = this.aliasTextBox.Text.Trim();


                int resultado = 0;

                if (this.cl.email != "") // Insertar
                {
                    resultado = cl.Insert(this.cl);
                    this.cargarDatos();

                }
                else
                {
                    MessageBox.Show("Error al crear cuenta");
                }

                if (resultado == 1)
                {
                    MessageBox.Show("Cliente guardado correctamente", "Exito", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Error al guardar cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.GuardarUsuario();
            this.cargarDatos();
        }
    }
}
