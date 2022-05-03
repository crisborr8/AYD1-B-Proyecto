using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockBusted.Models
{
    class PeliculaAdmin
    {
        public int ID_PELICULA { get; set; }
        public string NOMBRE { get; set; }
        public string PRECIO_X_DIA { get; set; }
        public string IMAGEN { get; set; }
        public string PELICULA_ACTIVA { get; set; }
        public string CODIGO_IDIOMA { get; set; }
        public string IDIOMA { get; set; }
        public string CODIGO_PLAN { get; set; }
        public string NOMBRE_PLAN { get; set; }

        string constr = Conexion.ConnectionString;

        public PeliculaAdmin()
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
                    using (MySqlCommand command = new MySqlCommand("sp_ver_lista_peliculas", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
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

        public int Insert(PeliculaAdmin pl)
        {
            int id = 0;
            DataSet datos = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    con.Open();
                    using (MySqlCommand command = new MySqlCommand("sp_crear_pelicula", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@i_nombre", pl.NOMBRE);
                        command.Parameters.AddWithValue("@i_imagen", pl.IMAGEN);
                        command.Parameters.AddWithValue("@i_precio_x_dia", pl.PRECIO_X_DIA);
                        command.Parameters.AddWithValue("@i_pelicula_activa", pl.PELICULA_ACTIVA);
                        command.Parameters.AddWithValue("@i_lenguaje", pl.CODIGO_IDIOMA);
                        command.Parameters.AddWithValue("@i_plan_alquiler", pl.CODIGO_PLAN);

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

        public int Update(PeliculaAdmin pl)
        {
            int id = 0;
            DataSet datos = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    con.Open();
                    using (MySqlCommand command = new MySqlCommand("sp_editar_pelicula", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@i_pelicula", pl.ID_PELICULA);
                        command.Parameters.AddWithValue("@i_nombre", pl.NOMBRE);
                        command.Parameters.AddWithValue("@i_imagen", pl.IMAGEN);
                        command.Parameters.AddWithValue("@i_precio_x_dia", pl.PRECIO_X_DIA);
                        command.Parameters.AddWithValue("@i_pelicula_activa", pl.PELICULA_ACTIVA);
                        command.Parameters.AddWithValue("@i_lenguaje", pl.CODIGO_IDIOMA);
                        command.Parameters.AddWithValue("@i_plan_alquiler", pl.CODIGO_PLAN);

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
