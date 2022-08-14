using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class ProductoVendido
    {
        //Definicion de parametros 
        public int id;
        public int idProducto;
        public int stock;
        public int idVenta;
        //Definicion de constructor vacio
        public ProductoVendido()
        {
            id = 0;
            idProducto = 0;
            stock = 0;
            idVenta = 0;
        }
        //Definicion de constructor parametrizado 
        public ProductoVendido(int id, int idProducto, int stock, int idVenta)
        {
            this.id = id;
            this.idProducto = idProducto;
            this.stock = stock;
            this.idVenta = idVenta;
        }
    }
}
