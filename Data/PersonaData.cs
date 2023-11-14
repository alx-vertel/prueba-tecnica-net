using prueba_tecnica_net.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace prueba_tecnica_net.Data
{
    public class PersonaData
    {
        //Registrar
        public static bool Registrar(Persona oPersona)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.urlConexion))
            {
                SqlCommand cmd = new SqlCommand("RegistrarPersona", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Identificador", oPersona.Identificador);
                cmd.Parameters.AddWithValue("@Nombres", oPersona.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", oPersona.Apellidos);
                cmd.Parameters.AddWithValue("@NumeroIdentificacion", oPersona.NumeroIdentificacion);
                cmd.Parameters.AddWithValue("@Email", oPersona.Email);
                cmd.Parameters.AddWithValue("@TipoIdentificacion", oPersona.TipoIdentificacion);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        //Listar Persona
        public static List<Persona> ListarPersonas()
        {
            List<Persona> oListaPersona = new List<Persona>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.urlConexion))
            {
                SqlCommand cmd = new SqlCommand("ConsultarPersonas", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oListaPersona.Add(new Persona()
                            {
                                Identificador = dr["Identificador"].ToString(),
                                Nombres = dr["Nombres"].ToString(),
                                Apellidos = dr["Apellidos"].ToString(),
                                NumeroIdentificacion = dr["NumeroIdentificacion"].ToString(),
                                Email = dr["Email"].ToString(),
                                TipoIdentificacion = dr["TipoIdentificacion"].ToString(),
                                FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"].ToString()),
                                NumeroIdentificacionConcat = dr["NumeroIdentificacionConcat"].ToString(),
                                NombreCompleto = dr["NombreCompleto"].ToString(),
                            });
                        }
                    }
                    return oListaPersona;
                }
                catch (Exception ex)
                {
                    return oListaPersona;
                }
            }

        }

    }
}