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
    public partial class GestionPeliculas : Form
    {
        PeliculaAdmin cl = new PeliculaAdmin();
        lenguaje len = new lenguaje();
        public GestionPeliculas()
        {
            InitializeComponent();
        }

        private void peliculaAdminDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GestionPeliculas_Load(object sender, EventArgs e)
        {
            this.cargarIdiomas();
            this.cargarPlanes();
            this.cargarDatos();
        }

        private void cargarDatos()
        {
            cl.ID_PELICULA = 0;
            cl.NOMBRE = "";
            cl.PRECIO_X_DIA = "";
            cl.IMAGEN = "";
            cl.PELICULA_ACTIVA = "";
            cl.IDIOMA = "";
            cl.CODIGO_PLAN = "";

            DataSet datos = cl.consulta();

            if (datos != null)
            {
                DataTable dt = new DataTable();
                dt = datos.Tables[0];
                this.peliculaAdminBindingSource.DataSource = dt;
                this.peliculaAdminDataGridView.DataSource = this.peliculaAdminBindingSource;
            }
            else
            {
                List<PeliculaAdmin> list = new List<PeliculaAdmin>();
                this.peliculaAdminBindingSource.DataSource = list;
                this.peliculaAdminDataGridView.DataSource = this.peliculaAdminBindingSource;
            }

        }

        private void cargarIdiomas()
        {


            DataSet datos = len.consulta();

            if (datos != null)
            {
                DataTable dt = new DataTable();
                dt = datos.Tables[0];


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string texto = dt.Rows[i]["CODIGO_LENGUAJE"].ToString() + "-" + dt.Rows[i]["NOMBRE_LENGUAJE"].ToString();
                    this.iDIOMAComboBox.Items.Add(texto);
                }

            }


        }

        private void cargarPlanes()
        {


            DataSet datos = len.consultaPlanes();

            if (datos != null)
            {
                DataTable dt = new DataTable();
                dt = datos.Tables[0];


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string texto = dt.Rows[i]["ID_PLAN"].ToString() + "-" + dt.Rows[i]["NOMBRE_PLAN"].ToString();
                    this.nOMBRE_PLANComboBox.Items.Add(texto);
                }

            }


        }

        public void GuardarPelicula(int operacion)
        {
            try
            {
                this.nOMBRE_PLANComboBox.SelectedItem.ToString();
                this.cl.ID_PELICULA = this.iD_PELICULATextBox.Text.Trim() != "" ? Convert.ToInt32(this.iD_PELICULATextBox.Text.Trim()) : 0;
                this.cl.NOMBRE = this.nOMBRETextBox.Text.Trim();
                this.cl.IMAGEN = this.iMAGENTextBox.Text.Trim();
                this.cl.PRECIO_X_DIA = this.pRECIO_X_DIATextBox.Text.Trim();

                this.cl.PELICULA_ACTIVA = this.pELICULA_ACTIVAComboBox.SelectedItem.ToString() == "SI" ? "1" : "0";
                this.cl.CODIGO_IDIOMA = this.iDIOMAComboBox.SelectedItem.ToString().Split('-')[0];
                this.cl.CODIGO_PLAN = this.nOMBRE_PLANComboBox.SelectedItem.ToString().Split('-')[0];


                int resultado = 0;

                if (this.cl.ID_PELICULA == 0 && operacion == 1) // Insertar
                {
                    resultado = cl.Insert(this.cl);
                    this.cargarDatos();

                }
                else if (this.cl.ID_PELICULA != 0 && operacion == 2) //actualizar
                {
                    resultado = cl.Update(this.cl);
                    this.cargarDatos();
                }
                else
                {
                    MessageBox.Show("Error al guardar pelicula");
                }

                if (resultado == 1)
                {
                    MessageBox.Show("Pelicula guardada correctamente", "Exito", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Error al guardar pelicula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            this.iD_PELICULATextBox.Text = "";
            this.nOMBRETextBox.Text = "";
            this.iMAGENTextBox.Text = "";
            this.pRECIO_X_DIATextBox.Text = "";

            this.nOMBRETextBox.Focus();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            int operacion = this.iD_PELICULATextBox.Text.Trim() == "" ? 1 : 2;
            this.GuardarPelicula(operacion);
        }
    }
}
