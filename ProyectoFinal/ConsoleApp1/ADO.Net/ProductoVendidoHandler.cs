using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class ProductoVendidoHandler : DbHandler
    {
        public List<ProductoVendido> GetProductosVendido(int IdUsuario)
        {
            List<ProductoVendido> productosvendido = new List<ProductoVendido>();
            String Query = "SELECT * From Producto AS P " +
                          "INNER JOIN ProductoVendido AS PV ON PV.IdProducto = @IdUsuario";

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = IdUsuario });
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                ProductoVendido productovendido = new ProductoVendido();
                                productovendido.id = Convert.ToInt32(reader["Id"]);
                                productovendido.idVenta = Convert.ToInt32(reader["idVenta"]);
                                productovendido.stock = Convert.ToInt32(reader["Stock"]);
                                productovendido.idProducto = Convert.ToInt32(reader["idProducto"]);
                                productosvendido.Add(productovendido);
                            }
                        }
                    }

                    sqlConnection.Close();
                }
            }
            return productosvendido;
        }
    }
}
