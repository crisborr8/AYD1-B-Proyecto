using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockBusted.Models
{
    class Pelicula
    {
        public int CODIGO { get; set; }
        public string NOMBRE_PELICULA { get; set; }
        public string PRECIO_X_DIA { get; set; }
        public string PORTADA_PELICULA { get; set; }
        public string VIDEO { get; set; }
        public string HABILITADA { get; set; }
        public string PLAN_ALQUILER { get; set; }


        string constr = Conexion.ConnectionString;

        public Pelicula()
        {

        }

        public DataSet getPeliculasCompradas(String email)
        {
            DataSet datos = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    con.Open();
                    using (MySqlCommand command = new MySqlCommand("sp_ver_peliculas_alquiladas_x_usr", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@i_email", email);
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

        public DataSet consulta()
        {
            DataSet datos = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    con.Open();
                    using (MySqlCommand command = new MySqlCommand("sp_ver_lista_peliculas", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                      //  command.Parameters.AddWithValue("@i_repuesto", -1);
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

        public int insertarEnAlquiler(String emailUser, int idPelicula, Double total)
        {
            DataSet datos = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    con.Open();
                    using (MySqlCommand command = new MySqlCommand("sp_alquilar_pelicula", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@i_email", emailUser);
                        command.Parameters.AddWithValue("@i_pelicula", idPelicula);
                        command.Parameters.AddWithValue("@i_total_alquiler", total);

                        using (MySqlDataAdapter sda = new MySqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(datos, "data");

                            con.Close();

                        }

                    }
                }
                return 1;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error" + ex.Number + " has occurred: " + ex.Message);
                return 0;
            }
        }


        public int insertarUsuario(String email, String nickname, String password,String nombre, String apellido,int edad, String dpi)
        {
            DataSet datos = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    con.Open();
                    using (MySqlCommand command = new MySqlCommand("sp_registro_usuario", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@i_email", email);
                        command.Parameters.AddWithValue("@i_usuario", nickname);
                        command.Parameters.AddWithValue("@i_password", password);
                        command.Parameters.AddWithValue("@i_nombre", nombre);
                        command.Parameters.AddWithValue("@i_apellido", apellido);
                        command.Parameters.AddWithValue("@i_dpi", dpi);
                        command.Parameters.AddWithValue("@i_edad", edad);
                       

                        using (MySqlDataAdapter sda = new MySqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(datos, "data");

                            con.Close();

                        }

                    }
                }
                return 1;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error" + ex.Number + " has occurred: " + ex.Message);
                return 0;
            }
        }

    }
}
