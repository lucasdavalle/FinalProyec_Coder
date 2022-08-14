using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class ProductoHandler:DbHandler
    {
        public List<Producto> GetProducto(int idUsuario)
        {
            List<Producto> productos = new List<Producto>();
            ProductoVendidoHandler productoVendidoHandler = new ProductoVendidoHandler();
            String Query = "SELECT * FROM Producto WHERE IdUsuario = @idUsuario";

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
                                Producto producto = new Producto();

                                producto.Id = Convert.ToInt32(reader["Id"]);
                                producto.Descripcion = (reader["Descripciones"]).ToString();
                                producto.Costo = Convert.ToInt32(reader["Costo"]);
                                producto.PrecioDeVenta = Convert.ToInt32(reader["PrecioVenta"]);
                                producto.Stock = Convert.ToInt32(reader["Stock"]);
                                producto.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);

                                productoVendidoHandler.GetProductosVendido(producto.IdUsuario);
                                productos.Add(producto);
                            }
                        }
                    }

                    sqlConnection.Close();
                }
            }
            return productos;
        }
    }
}
