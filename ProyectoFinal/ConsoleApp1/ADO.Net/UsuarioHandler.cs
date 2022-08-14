using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class UsuarioHandler :DbHandler
    {
        public Usuario GetUsuario(string NombreUsuario)
        {
            Usuario usuario = new Usuario();
            String Query = "SELECT * FROM Usuario WHERE NombreUsuario = @NombreUsuario";

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = NombreUsuario });

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                
                                usuario.Id = Convert.ToInt32(reader["Id"]);
                                usuario.Nombre = (reader["Nombre"]).ToString();
                                usuario.Apellido = (reader["Apellido"]).ToString();
                                usuario.NombreUsuario = (reader["NombreUsuario"]).ToString();
                                usuario.Contraseña = (reader["Contraseña"]).ToString();
                                usuario.Mail = (reader["Mail"]).ToString();

                            }
                        }
                    }
                    sqlConnection.Close();
                }
            }
            return usuario;
        }

    }
}
