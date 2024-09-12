
namespace BootCamp_SOLID._4_Interface_Segregation
{
    public interface IAvesS
    {
        void SetLocalizacao(double longitude, double latitude);
        void Renderizar();
    }

    public interface IAvesQueVoam : IAvesS
    {
        void SetAltitude(double altitude);
    }

    public class PapagaioS : IAvesQueVoam
    {
        public void SetLocalizacao(double longitude, double latitude)
        {
            // Faz alguma coisa
        }

        public void SetAltitude(double altitude)
        {
            // Faz alguma coisa   
        }

        public void Renderizar()
        {
            // Faz alguma coisa
        }
    }

    public class PinguimS : IAvesS
    {
        public void SetLocalizacao(double longitude, double latitude)
        {
            // Faz alguma coisa
        }

        public void Renderizar()
        {
            // Faz alguma coisa
        }
    }
}
