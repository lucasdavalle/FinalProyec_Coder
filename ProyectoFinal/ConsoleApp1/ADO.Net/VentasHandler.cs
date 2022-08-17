using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class VentasHandler : DbHandler
    {
        public List<Venta> GetVentas(int idUsuario)
        {
            List<Venta> ventas = new List<Venta>();
            ProductoVendidoHandler productoVendidoHandler = new ProductoVendidoHandler();
            string Query = "SELECT DISTINCT V.* FROM Venta AS V " +
                           "INNER JOIN ProductoVendido AS PV ON V.Id = PV.IdVenta" +
                           "INNER JOIN Producto AS P ON PV.IdProducto = P.Id" +
                           "WHERE P.IdUsuario = @idUsuario";

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = idUsuario });
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Venta venta = new Venta();

                                venta.id = Convert.ToInt32(reader["Id"]);
                                venta.Comentarios = (reader["Comentarios"]).ToString();
                                ventas.Add(venta);
                            }
                        }
                    }

                    sqlConnection.Close();
                }
            }
            return ventas;
        }
    }
}
