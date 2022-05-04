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
    public partial class PeliculasCompradas : Form
    {
        String email;
        Models.Pelicula pl = new Models.Pelicula();
        public PeliculasCompradas(String email) 
        {
            InitializeComponent();
            this.email = email;
            CargarDatos(); 
        }

        private void CargarDatos()
        {
            this.dgv_Peliculas.Rows.Clear();
            DataSet a = this.pl.getPeliculasCompradas(this.email);
            DataTable dt = a.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                if (dr.ItemArray[6].ToString() == "ACTIVO")
                    this.dgv_Peliculas.Rows.Add(dr.ItemArray);
            }
        }
    }
}
