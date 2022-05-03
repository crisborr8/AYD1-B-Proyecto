using BlockBusted.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockBusted
{
    public partial class Lenguajes : Form
    {
        lenguaje len = new lenguaje();
        public Lenguajes()
        {
            InitializeComponent();
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lenguajes_Load(object sender, EventArgs e)
        {
            this.cargarDatos();
        }

        private void cargarDatos()
        {
           // len.id = 0;
            len.NOMBRE_LENGUAJE = "";

            DataSet datos = len.consulta();

            if (datos != null)
            {
                DataTable dt = new DataTable();
                dt = datos.Tables[0];
                this.lenguajeBindingSource.DataSource = dt;
                this.lenguajeDataGridView.DataSource = this.lenguajeBindingSource;
            }
            else
            {
                List<lenguaje> list = new List<lenguaje>();
                this.lenguajeBindingSource.DataSource = list;
                this.lenguajeDataGridView.DataSource = this.lenguajeBindingSource;
            }

        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            this.cODIGO_LENGUAJETextBox.Text = "";
            this.nOMBRE_LENGUAJETextBox.Text = "";
            
            this.nOMBRE_LENGUAJETextBox.Focus();
        }

        public void GuardarLenguaje(int operacion)
        {
            try
            {
                this.len.CODIGO_LENGUAJE = this.cODIGO_LENGUAJETextBox.Text.Trim() != "" ? Convert.ToInt32(this.cODIGO_LENGUAJETextBox.Text.Trim()) : 0;
                this.len.NOMBRE_LENGUAJE = this.nOMBRE_LENGUAJETextBox.Text.Trim();

                int resultado = 0;

                if (this.len.CODIGO_LENGUAJE == 0 && operacion == 1) // Insertar
                {
                    resultado = len.Insert(this.len);
                    this.cargarDatos();

                }
                else if (this.len.CODIGO_LENGUAJE != 0 && operacion == 2) //actualizar
                {
                    resultado = len.Update(this.len);
                    this.cargarDatos();
                }
                else
                {
                    MessageBox.Show("Error al guardar lenguaje");
                }

                if (resultado == 1)
                {
                    MessageBox.Show("Lenguaje guardado correctamente", "Exito", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Error al guardar lenguaje", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            int operacion = this.cODIGO_LENGUAJETextBox.Text.Trim() == "" ? 1 : 2;
            this.GuardarLenguaje(operacion);
        }

        private void limpiar_Click_1(object sender, EventArgs e)
        {
            this.cODIGO_LENGUAJETextBox.Text = "";
            this.nOMBRE_LENGUAJETextBox.Text = "";
            
            this.cODIGO_LENGUAJETextBox.Focus();
        }
    }
}
