namespace BootCamp_SOLID._2_OpenClosed
{
    internal class Solution
    {
        public interface IRemuneravel
        {
            decimal Remuneracao();
        }

        public class ContratoClt : IRemuneravel
        {
            public decimal Remuneracao()
            {
                return 0m;
            }
        }

        public class Estagio : IRemuneravel
        {
            public decimal Remuneracao()
            {
                return 0m;
            }
        }

        public class ContratoPj : IRemuneravel
        {
            public decimal Remuneracao()
            {
                return 0m;
            }
        }

        public class FolhaDePagamento
        {
            protected decimal saldo;

            public void Calcular(IRemuneravel funcionario)
            {
                saldo = funcionario.Remuneracao();
            }
        }
    }
}
