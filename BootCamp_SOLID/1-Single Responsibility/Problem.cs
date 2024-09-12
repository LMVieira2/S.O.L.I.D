//Uma classe deve ter um, e somente um, motivo para mudar.

namespace BootCamp_SOLID._1_Single_Responsibility
{
    public class Order
    {
        public void CalculateTotalSum()
        {
        }

        public void GetItems()
        {
        }

        public void GetItemCount()
        {
        }

        public void AddItem(object item)
        {
        }

        public void DeleteItem(object item)
        {
        }

        public void PrintOrder()
        {
        }

        public void ShowOrder()
        {
        }

        public void Load()
        {
        }

        public void Save()
        {
        }

        public void Update()
        {
        }

        public void Delete()
        {
        }
    }
}


//Erros:
//Falta de coesão — uma classe não deve assumir responsabilidades que não são suas;
//Alto acoplamento — Mais responsabilidades geram um maior nível de dependências, deixando o sistema engessado e frágil para alterações;
//Dificuldades na implementação de testes automatizados — É difícil de “mockar” esse tipo de classe;
//Dificuldades para reaproveitar o código;
//Dificuldades para entender o código — Quanto mais responsabilidades, mais difícil de entender o código.