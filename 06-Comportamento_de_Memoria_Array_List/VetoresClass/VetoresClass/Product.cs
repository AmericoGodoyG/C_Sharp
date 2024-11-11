
using System.Globalization;

namespace VetoresClass
{
    internal class Product
    {
        public string Name { get; set; }

        public double Price { get; set; }

        // Método da classe Obeject do system. Permite que um objeto seja exibido em forma de string
        public override string ToString()
        {
            return "Nome: " + Name 
                 + "\nPreco R$ " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
