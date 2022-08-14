namespace ProyectoFinal
{
    public class ProbarObjetos
    {
        static void Main(string[] args)
        {
            ProductoHandler productoHandler = new ProductoHandler();
            UsuarioHandler usuarioHandler = new UsuarioHandler();
            Loggin loggin = new Loggin();
            productoHandler.GetProducto(1);
            usuarioHandler.GetUsuario("eperez");
            loggin.InicioSeccion("eperez", "1");
            
        }
    }
}