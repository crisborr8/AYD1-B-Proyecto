﻿using MySql.Data.MySqlClient;
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

        public DataSet consulta()
        {
            DataSet datos = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    con.Open();
                    using (MySqlCommand command = new MySqlCommand("sp_consulta_repuesto", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@i_repuesto", -1);
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

    }
}