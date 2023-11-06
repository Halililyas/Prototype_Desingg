using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Desing
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "halil", LastName = "Kap", Ctiy = "İstanbul" };
            Customer customer2 = (Customer)customer1.Clone(); // Burda Clone Kullanarak Customer İçerisinde bulunan özellikleri bidaha ürettiğimiz de Yeniden Bir referans Üretmekten Kaçınmış oluyoruz
            customer2.FirstName="Hızır";

            Console.WriteLine(customer1.FirstName);
            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }
    public abstract class Person
    {
        public abstract Person Clone();
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class Customer: Person
    {
        public string Ctiy { get; set; }

        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }
    public class Employee : Person
    {
        public string Salary { get; set; } // KEndine ait Bir Metotd

        public override Person Clone()
        {
            return (Person)MemberwiseClone(); // Burda Person Sınıfının İçindekiileri Kolonladık 
        }
    }
}
