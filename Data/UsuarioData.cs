using prueba_tecnica_net.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace prueba_tecnica_net.Data
{
    public class UsuarioData
    {
        //Consultar Usuario
        public static Persona ConsultarUsuarioPersona(string User, string Pass)
        {
            Persona oPersona = null;
            using (SqlConnection oConexion = new SqlConnection(Conexion.urlConexion))
            {
                SqlCommand cmd = new SqlCommand("ConsultarUsuarioPersona", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Usuario", User);
                cmd.Parameters.AddWithValue("@Pass", Pass);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oPersona = new Persona()
                            {
                                Identificador = dr["Identificador"].ToString(),
                                Nombres = dr["Nombres"].ToString(),
                                Apellidos = dr["Apellidos"].ToString(),
                                NumeroIdentificacion = dr["NumeroIdentificacion"].ToString(),
                                Email = dr["Email"].ToString(),
                                TipoIdentificacion = dr["TipoIdentificacion"].ToString(),
                                FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]),
                                NumeroIdentificacionConcat = dr["NumeroIdentificacionConcat"].ToString(),
                                NombreCompleto = dr["NombreCompleto"].ToString()
                            };
                        }
                    }

                    return oPersona;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        //Registrar
        public static bool RegistrarUsuario(Usuario usuario)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.urlConexion))
            {
                SqlCommand cmd = new SqlCommand("RegistrarUsuario", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Identificador", usuario.Identificador);
                cmd.Parameters.AddWithValue("@Usuario", usuario.User);
                cmd.Parameters.AddWithValue("@Pass", usuario.Pass);
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
    }
}