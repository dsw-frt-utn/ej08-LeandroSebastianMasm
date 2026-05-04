namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductHelper helper = new ProductHelper();
            string etiqueta = helper.ObtenerEtiquetaProducto(12345, "Laptop Gamer", 1200.50m);

            Console.WriteLine(etiqueta);
        }
    }
}
