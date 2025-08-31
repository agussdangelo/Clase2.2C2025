using Clase2._2C2025.Entidad;

namespace Clase2._2C2025.Logica
{
    public interface IDuplexServicio
    {
        void AgregarDuplex(Duplex duplex);
        List<Duplex> ObtenerDuplexes();
    }

    public class DuplexServicio: IDuplexServicio
    {
        private List<Duplex> duplexList;

        public DuplexServicio()
        {
            duplexList = new List<Duplex>();
        }

        public void AgregarDuplex(Duplex duplex)
        {
            duplexList.Add(duplex);
        }

        public List<Duplex> ObtenerDuplexes()
        {
            return duplexList;
        }

    }
}
