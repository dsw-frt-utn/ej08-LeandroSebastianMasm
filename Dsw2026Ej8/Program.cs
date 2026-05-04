namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductHelper helper = new ProductHelper();
            string etiqueta = helper.ObtenerEtiquetaProducto(12345, "Laptop Gamer", 1200.50m);

            Console.WriteLine(etiqueta);

            Problema4 Prom = new Problema4 ();
            double ABC = Prom.CalcularPromedio(null, 1, 10);
            Console.WriteLine(ABC);
            //-----------------------------------------------------------------------------
            var prob5 = new Problema5();

            RetailSale ventaMinorista = new RetailSale();
            ventaMinorista.Importe= 100;
            WholeSale ventaMayorista = new WholeSale();
            ventaMayorista.Importe = 100;

            Console.WriteLine(prob5.ObtenerImporteFinal(ventaMinorista));
            Console.WriteLine(prob5.ObtenerImporteFinal(ventaMayorista)); 
        }
    }
}
