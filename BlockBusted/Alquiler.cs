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
    public partial class Alquiler : Form
    {
        //Variables para la conexion 
        Models.Pelicula pl = new Models.Pelicula();
        public Alquiler()
        {
            InitializeComponent();
            cargarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String a = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            String b = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            String c = this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            String d = this.dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            String j = this.dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            String f = this.dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            String g = this.dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            String h = this.dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            String i = this.dataGridView1.SelectedRows[0].Cells[8].Value.ToString();


            this.dataGridView2.Rows.Add(a,b,c,d,j,f,g,h,i);
        }

        private void cargarDatos()
        {
            pl.CODIGO = 0;
            pl.HABILITADA = "";
            pl.NOMBRE_PELICULA = "";
            pl.PLAN_ALQUILER = "";
            pl.PORTADA_PELICULA = "";
            pl.PRECIO_X_DIA = "";
            pl.VIDEO = "";
            this.dataGridView1.Rows.Clear();
           // this.dataGridView1.Columns.Clear();

            DataSet a;
        
                a = this.pl.consulta();
            
       
            

            DataTable dt = a.Tables[0];
           /* foreach (DataColumn dc in dt.Columns)
            {

                this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());

            }*/

            foreach (DataRow dr in dt.Rows)
            {
                if (dr.ItemArray[4].ToString().Equals("SI"))
               {
                    this.dataGridView1.Rows.Add(dr.ItemArray);
                }
            }

        }
    }
}
