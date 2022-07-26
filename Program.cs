//PRIMER DESAFIO ENTREGABLE
//Nombre: Lucas Davalle 

//Definicion de namespace para mejor organizacion 
namespace DesafioEntregable 
{
    //Clase Principal 
    class dataBase
    {
        static void Main(string[] args)
        {
        }
    }
}

//Definicion de clases
public class Usuario 
{
    //Definicion de parametros 
    private int id;
    private string Nombre;
    private string Apellido;
    private string NombreUsuario;
    private string Contraseña;
    private string Mail;
    //Definicion de constructor parametrizado 
    public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contraseña, string mail)
    {
        this.id = id;
        Nombre = nombre;
        Apellido = apellido;
        NombreUsuario = nombreUsuario;
        Contraseña = contraseña;
        Mail = mail;
    }

}
public class Producto
{
    //Definicion de parametros 
    private int id;
    private int idUsuario;
    private string Descripcion;
    private string Costo;
    private string PrecioVenta;
    private string Stock;
    //Definicion de constructor parametrizado 
    public Producto(int id, int idUsuario, string descripcion, string costo, string precioVenta, string stock)
    {
        this.id = id;
        this.idUsuario = idUsuario;
        Descripcion = descripcion;
        Costo = costo;
        PrecioVenta = precioVenta;
        Stock = stock;
    }
}
public class ProductoVendido
{
    //Definicion de parametros 
    private int id;
    private int idProducto;
    private string stock;
    private string idVenta;
    //Definicion de constructor parametrizado 
    public ProductoVendido(int id, int idProducto, string stock, string idVenta)
    {
        this.id = id;
        this.idProducto = idProducto;
        this.stock = stock;
        this.idVenta = idVenta;
    }
}
public class Venta
{
    //Definicion de parametros 
    private int id;
    private string Comentarios;
    //Definicion de constructor parametrizado 
    public Venta(int id, string comentarios)
    {
        this.id = id;
        Comentarios = comentarios;
    }
}