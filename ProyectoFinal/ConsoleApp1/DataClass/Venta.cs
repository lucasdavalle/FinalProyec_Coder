using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class Venta
    {
        //Definicion de parametros 
        public int id;
        public string Comentarios;
        //Definicion de constructor vacio
        public Venta()
        {
            id = 0;
            Comentarios = String.Empty;
        }
        //Definicion de constructor parametrizado 
        public Venta(int id, string comentarios)
        {
            this.id = id;
            Comentarios = comentarios;
        }

    }
}
