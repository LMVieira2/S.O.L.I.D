//Objetos ou entidades devem estar abertos para extensão, mas fechados para modificação

namespace BootCamp_SOLID._2_OpenClosed
{
    public class ContratoClt
    {
        public decimal Salario()
        {
            return 0m;
        }
    }

    public class Estagio
    {
        public decimal BolsaAuxilio()
        {
            return 0m;
        }
    }

    public class FolhaDePagamento
    {
        protected decimal saldo;

        public void Calcular(object funcionario)
        {
            if (funcionario is ContratoClt contratoClt)
            {
                saldo = contratoClt.Salario();
            }
            else if (funcionario is Estagio estagio)
            {
                saldo = estagio.BolsaAuxilio();
            }
        }
    }
}

//Erros:
//1. A classe FolhaDePagamento não está fechada para modificação, pois toda vez que um novo tipo de funcionário for adicionado, será necessário modificar a classe para adicionar um novo if
//2. A classe FolhaDePagamento não está aberta para extensão, pois não é possível adicionar um novo tipo de funcionário sem modificar a classe
//3. A classe FolhaDePagamento não está coesa, pois ela tem mais de uma razão para mudar, uma para cada tipo de funcionário

//Supondo que a empresa cresceu e resolveu trabalhar com funcionários PJ, obviamente seria necessário modificar essa classe! 
//Não seria mais fácil apenas acrescentar mais um IF e verificar o novo tipo de funcionário PJ aplicando as respectivas regras? Sim, porém, alterar uma classe já existente para adicionar um novo comportamento, corremos um sério risco de introduzir bugs em algo que já estava funcionando.