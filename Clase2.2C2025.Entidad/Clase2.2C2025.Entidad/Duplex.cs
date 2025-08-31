namespace Clase2._2C2025.Entidad
{
    public class Duplex
    {
        public string Fecha { get; set; }

        public string Cliente { get; set; }

        public string NumeroDuplex { get; set; }

        public string NumeroPersonas { get; set; }

        public string Precio { get; set; }

        public Duplex(string fecha, string cliente, string numeroDuplex, string numeroPersonas, string precio)
        {
            Fecha = fecha;
            Cliente = cliente;
            NumeroDuplex = numeroDuplex;
            NumeroPersonas = numeroPersonas;
            Precio = precio;
        }

    }
}
