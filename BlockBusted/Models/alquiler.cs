using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Data;

namespace BlockBusted.Models
{
    public class alquiler
    {

        public int ID_PLAN { get; set; }
        public string NOMBRE_PLAN { get; set; }

        public int DIAS_X_COBRAR { get; set; }

        public int DIAS_OFERTA { get; set; }

        public decimal MULTA { get; set; }

        string constr = Conexion.ConnectionString;

        public alquiler()
        {

        }

        public DataSet consulta()
        {
            DataSet datos = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    con.Open();
                    using (MySqlCommand command = new MySqlCommand("sp_ver_planes_alquiler", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        //command.Parameters.AddWithValue("@i_repuesto", -1);
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(datos, "data");

                            con.Close();

                        }

                    }
                }
                return datos;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error" + ex.Number + " has occurred: " + ex.Message);
                return null;
            }
        }

        public int Insert(alquiler ln)
        {
            int id = 0;
            DataSet datos = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    con.Open();
                    using (MySqlCommand command = new MySqlCommand("sp_crear_plan_alquiler", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@i_nombre_plan", ln.NOMBRE_PLAN);
                        command.Parameters.AddWithValue("@i_dias_x_cobrar", ln.DIAS_X_COBRAR);
                        command.Parameters.AddWithValue("@i_dias_oferta", ln.DIAS_OFERTA);
                        command.Parameters.AddWithValue("@i_multa", ln.MULTA);

                        using (MySqlDataAdapter sda = new MySqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(datos, "data");
                            id = 1;

                            con.Close();

                        }

                    }
                }
                return id;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error" + ex.Number + " has occurred: " + ex.Message);
                return 0;
            }
        }

        public int Update(alquiler ln)
        {
            int id = 0;
            DataSet datos = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    con.Open();
                    using (MySqlCommand command = new MySqlCommand("sp_editar_plan_alquiler", con))
                    {


                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@i_id_plan", Convert.ToInt32(ln.ID_PLAN));

                        command.Parameters.AddWithValue("@i_nombre_plan", ln.NOMBRE_PLAN);
                        command.Parameters.AddWithValue("@i_dias_x_cobrar", ln.DIAS_X_COBRAR);
                        command.Parameters.AddWithValue("@i_dias_oferta", ln.DIAS_OFERTA);
                        command.Parameters.AddWithValue("@i_multa", ln.MULTA);

                        using (MySqlDataAdapter sda = new MySqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(datos, "data");
                            id = 1;

                            con.Close();

                        }

                    }
                }
                return id;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error" + ex.Number + " has occurred: " + ex.Message);
                return 0;
            }
        }


        public int Delete()
        {
            int id = 0;
            DataSet datos = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("sp_eliminar_plan_alquiler", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@i_id_plan", ID_PLAN.ToString().Trim());
                        //cmd.Parameters.AddWithValue("@i_id_plan", Convert.ToInt32(this.ln.ID_PLAN));
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(datos, "data");
                            id = 1;
                        }
                    }
                }
                return id;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error " + ex.Number + " a ocurrido " + ex.Message);
                return 0;
            }
        }



    }
}
