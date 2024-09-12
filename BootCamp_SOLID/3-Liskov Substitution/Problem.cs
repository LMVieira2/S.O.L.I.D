//Uma classe derivada deve ser substituível por sua classe base.

namespace BootCamp_SOLID._3_Liskov_Substitution
{

    public class Principal
    {
        public void Teste(Pato pato)
        {
            pato.Nadar();
        }

        public class Pato
        {

           public virtual void Nadar()
            {
                //Nadou
            }
        }

        public class PatoDeBrinquedo : Pato
        {
            private bool temBateria;

            public override void Nadar()
            {
                //if (temBateria)
                // Nadou
            }
        }
    }
}

//Erros:
//1. A classe PatoDeBrinquedo não é substituível pela classe Pato, pois a classe PatoDeBrinquedo não possui a mesma funcionalidade da classe Pato.
//2. Com o detalhe de ter bateria, o teste de nadar não é mais o mesmo, pois o teste de nadar do PatoDeBrinquedo depende de uma bateria.
//3. Por mais que PatoDeBrinquedo tenha o metodo nadar, por ter o detalhe de ter bateria, ao realizar o teste, sera quebrado a regra de liskov. 