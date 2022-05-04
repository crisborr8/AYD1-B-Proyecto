using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockBusted.Models
{
    class lenguaje
    {
        public int CODIGO_LENGUAJE { get; set; }
        public string NOMBRE_LENGUAJE { get; set; }

        string constr = Conexion.ConnectionString;

        public lenguaje()
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
                    using (MySqlCommand command = new MySqlCommand("sp_ver_lenguajes", con))
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

        public int Insert(lenguaje ln)
        {
            int id = 0;
            DataSet datos = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    con.Open();
                    using (MySqlCommand command = new MySqlCommand("sp_crear_lenguaje", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@i_nombre", ln.NOMBRE_LENGUAJE);                     

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

        public int Update(lenguaje ln)
        {
            int id = 0;
            DataSet datos = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    con.Open();
                    using (MySqlCommand command = new MySqlCommand("sp_editar_lenguaje", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@i_id", Convert.ToInt32(ln.CODIGO_LENGUAJE));
                        command.Parameters.AddWithValue("@i_nombre", ln.NOMBRE_LENGUAJE);

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
    }
}
