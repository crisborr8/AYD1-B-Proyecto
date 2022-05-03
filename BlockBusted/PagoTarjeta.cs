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
    public partial class PagoTarjeta : Form
    {
        //Variable que contendrá todos los datos de la transaccion de peliculas
        DataGridView datosAlquiler;
        Models.Pelicula alquiler = new Models.Pelicula();
        public PagoTarjeta(DataGridView datos)
        {
            this.datosAlquiler = datos;
            //this.totalAlquiler();
            InitializeComponent();
            this.totalAlquiler();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox4.Text.Equals(""))
            {
                MessageBox.Show("FALTAN DATOS PARA FINALIZAR LA TRANSACCION");
            }
            else
            {
                for (int i = 0; i < this.datosAlquiler.Rows.Count; i++)
                {
                    int id = Convert.ToInt32(this.datosAlquiler.Rows[i].Cells[0].Value.ToString());
                    Double total = Convert.ToDouble(this.datosAlquiler.Rows[i].Cells[2].Value.ToString());
                    alquiler.insertarEnAlquiler("soluna@gmail.com", id, total);
                }
            }
        }

        private void totalAlquiler()
        {
            Double totalNumerico = 0;
            for(int i =0;i<this.datosAlquiler.Rows.Count;i++)
            {
                Double temporal = Convert.ToDouble(this.datosAlquiler.Rows[i].Cells[2].Value.ToString());
                totalNumerico = totalNumerico + temporal;
            }

            this.label8.Text = totalNumerico.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
            }
    }
}
