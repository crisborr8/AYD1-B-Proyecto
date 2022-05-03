using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockBusted.Models
{
    class Usuario
    {
        public string email { get; set; }
        public string alias { get; set; }
        public string clave { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string edad { get; set; }
        public string dpi { get; set; }


        string constr = Conexion.ConnectionString;

        public Usuario()
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
                    using (MySqlCommand command = new MySqlCommand("sp_ver_cuentas", con))
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

        public int Insert(Usuario usuario)
        {
            int id = 0;
            DataSet datos = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    con.Open();
                    using (MySqlCommand command = new MySqlCommand("sp_registro_usuario", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@i_usuario", usuario.alias);
                        command.Parameters.AddWithValue("@i_email", (usuario.email));
                        command.Parameters.AddWithValue("@i_nombre", (usuario.nombre));
                        command.Parameters.AddWithValue("@i_apellido", (usuario.apellido));
                        command.Parameters.AddWithValue("@i_dpi", (usuario.dpi));
                        command.Parameters.AddWithValue("@i_edad", Convert.ToInt32(usuario.edad));
                        command.Parameters.AddWithValue("@i_password", (usuario.clave));

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

        public int Update(Usuario usuario)
        {
            int id = 0;
            DataSet datos = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    con.Open();
                    using (MySqlCommand command = new MySqlCommand("sp_editar_usuario", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@i_usuario", usuario.alias);
                        command.Parameters.AddWithValue("@i_email", (usuario.email));
                        command.Parameters.AddWithValue("@i_nombre", (usuario.nombre));
                        command.Parameters.AddWithValue("@i_apellido", (usuario.apellido));
                        command.Parameters.AddWithValue("@i_dpi", (usuario.dpi));
                        command.Parameters.AddWithValue("@i_edad", Convert.ToInt32(usuario.edad));
                        command.Parameters.AddWithValue("@i_password", (usuario.clave));

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