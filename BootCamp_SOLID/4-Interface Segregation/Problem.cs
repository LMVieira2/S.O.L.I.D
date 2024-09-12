//classe não deve ser forçada a implementar interfaces e métodos que não irão utilizar.

namespace BootCamp_SOLID._4_Interface_Segregation
{
    public interface IAves
    {
        void SetLocalizacao(double longitude, double latitude);
        void SetAltitude(double altitude);
        void Renderizar();
    }

    public class Papagaio : IAves
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

    public class Pinguim : IAves
    {
        public void SetLocalizacao(double longitude, double latitude)
        {
            // Faz alguma coisa
        }

        // A Interface IAves está forçando a Classe Pinguim a implementar esse método.
        // Isso viola o princípio ISP
        public void SetAltitude(double altitude)
        {
            // Não faz nada... Pinguins são aves que não voam!
        }

        public void Renderizar()
        {
            // Faz alguma coisa
        }
    }
}

//Erros:
//1. A Interface IAves está forçando a Classe Pinguim a implementar o método SetAltitude, que não é utilizado por Pinguins.
// Dessa forma estamos não apenas violando o princípio ISP, mas também o princípio SRP, pois estamos forçando a classe a ter um método que não é utilizado.