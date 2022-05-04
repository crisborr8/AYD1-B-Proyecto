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
    public partial class Transferencia : Form
    {
        private String email;
        Models.Pelicula pl = new Models.Pelicula();
        public Transferencia(String email)
        {
            InitializeComponent();
            this.email = email;
            CargarDatos();
        }
        private void CargarDatos()
        {
            this.cb_peliculas.Items.Clear();
            DataSet a = this.pl.getPeliculasCompradas(this.email);
            DataTable dt = a.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                CbItem item = new CbItem();
                item.Text = dr.ItemArray[1].ToString();
                item.Value = dr.ItemArray[0];
                this.cb_peliculas.Items.Add(item);
            }
            this.cb_peliculas.SelectedIndex = 0;
        }

        private void btn_Trasnferir_Click(object sender, EventArgs e)
        {
            if(txt_Correo.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese un correo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataSet res = pl.transferir(this.email, txt_Correo.Text, (int)((CbItem)this.cb_peliculas.SelectedItem).Value);
                MessageBox.Show(res.Tables[0].Rows[0].ItemArray[1] + "");
                CargarDatos();
            }
        }
    }

    public class CbItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
