using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b2 = new Book("Толстой Л.Н.", "Война и мир", "Наука", 823, 2013);
            Book.SetPrice(12);
            b2.Show();
            Console.WriteLine("\n Итоговая стоимость аренды: {0} p.", b2.PriceBook(3));


        }
    }
}
