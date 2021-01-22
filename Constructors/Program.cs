using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // Customer customer = new Customer(); //örnek - instance // metot gibi 
            //Customer customer1 = new Customer 
            //{ Id = 78, FirstName = "Fatime" , LastName = "Yükkaldıran", City = "Şanlıurfa"};

            Customer customer2 = new Customer(2, "Eray", "Erten", "Bursa");
            Console.WriteLine(customer2.Id);
            Console.WriteLine(customer2.FirstName);

            Customer customer3 = new Customer();
            customer3.FirstName = "Kadir";
            customer3.LastName = "Doğan";

            //Method(4, "Ezgi", "Kılıçaslan", "Malatya");
        }

        //static void Method(int id, string firstName, string lastName, string city)
        //{

        //}
    }


    class Customer
    {
        public Customer()
        {

        }
        public Customer(int id, string firstname, string lastname, string city) //bir sınıftan bir instance oluşturduğumuzda arka planda default olarak çalışır, yazmasak da
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            City = city;
            //Console.WriteLine(Id);
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
