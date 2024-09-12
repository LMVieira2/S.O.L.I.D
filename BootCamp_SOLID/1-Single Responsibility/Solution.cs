namespace BootCamp_SOLID._1_Single_Responsibility
{
    public class OrderSolution
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
    }

    public class OrderRepository
    {
        public void Load(int orderID)
        {
        }

        public void Save(Order order)
        {
        }

        public void Update(Order order)
        {
        }

        public void Delete(Order order)
        {
        }
    }

    public class OrderViewer
    {
        public void PrintOrder(Order order)
        {
        }

        public void ShowOrder(Order order)
        {
        }
    }
}
// O princípio da responsabilidade única não se limita somente a classes, ele também pode ser aplicado em métodos e funções, ou seja, tudo que é responsável por executar uma ação, deve ser responsável por apenas aquilo que se propõe a fazer.