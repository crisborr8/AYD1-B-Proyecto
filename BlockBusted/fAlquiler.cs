using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlockBusted.Models;

namespace BlockBusted
{
    public partial class fAlquiler : Form
    {
        alquiler len = new alquiler();
        public fAlquiler()
        {
            InitializeComponent();
        }

        private void fAlquiler_Load(object sender, EventArgs e)
        {
            this.cargarDatos();
        }

        private void cargarDatos()
        {
            // len.id = 0;
            len.NOMBRE_PLAN = "";
            len.DIAS_X_COBRAR = 0;
            len.DIAS_OFERTA = 0;
            len.MULTA = 0;

            DataSet datos = len.consulta();

            if (datos != null)
            {
                DataTable dt = new DataTable();
                dt = datos.Tables[0];
                this.alquilerBindingSource.DataSource = dt;
                this.alquilerDataGridView.DataSource = this.alquilerBindingSource;
            }
            else
            {
                List<alquiler> list = new List<alquiler>();
                this.alquilerBindingSource.DataSource = list;
                this.alquilerDataGridView.DataSource = this.alquilerBindingSource;
            }

        }


        public void GuardarAlquiler(int operacion)
        {
            try
            {
                this.len.ID_PLAN = this.iD_PLANTextBox.Text.Trim() != "" ? Convert.ToInt32(this.iD_PLANTextBox.Text.Trim()) : 0;
                this.len.NOMBRE_PLAN = this.nOMBRE_PLANTextBox.Text.Trim();
                this.len.DIAS_X_COBRAR = this.dIAS_X_COBRARTextBox.Text.Trim() != "" ? Convert.ToInt32(this.dIAS_X_COBRARTextBox.Text.Trim()) : 0;
                this.len.DIAS_OFERTA = this.dIAS_OFERTATextBox.Text.Trim() != "" ? Convert.ToInt32(this.dIAS_OFERTATextBox.Text.Trim()) : 0;
                this.len.MULTA = this.mULTATextBox.Text.Trim() != "" ? Convert.ToDecimal(this.mULTATextBox.Text.Trim()) : 0;

                int resultado = 0;

                if (this.len.ID_PLAN == 0 && operacion == 1) // Insertar
                {
                    resultado = len.Insert(this.len);
                    this.cargarDatos();

                }
                else if (this.len.ID_PLAN != 0 && operacion == 2) //actualizar
                {
                    resultado = len.Update(this.len);
                    this.cargarDatos();
                }
                else
                {
                    MessageBox.Show("Error al guardar Plan de alquiler1");
                }

                if (resultado == 1)
                {
                    MessageBox.Show("Plan alquiler guardado correctamente", "Exito", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Error al guardar Plan alquiler2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            int operacion = this.iD_PLANTextBox.Text.Trim() == "" ? 1 : 2;
            this.GuardarAlquiler(operacion);
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            this.dIAS_OFERTATextBox.Text = "";
            this.dIAS_X_COBRARTextBox.Text = "";
            this.iD_PLANTextBox.Text = "";



            this.mULTATextBox.Text = "";


            this.nOMBRE_PLANTextBox.Text = "";

            this.iD_PLANTextBox.Focus();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {/*
            try
            {
                if (this.iD_PLANTextBox.Text.Trim() != "")
                {
                    DialogResult dialogResult = MessageBox.Show("Estas seguro de eliminar el registro?", "BORRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        len.ID_PLAN = int.Parse(this.iD_PLANTextBox.Text.Trim());
                        int resultado = len.Delete();
                        if (resultado > 0)
                        {
                            MessageBox.Show("Se elimino correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Ocurrio un error al eliminar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.cargarDatos();
            }*/
        }
    }
 }

