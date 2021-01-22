using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int,decimal,float,enum --->value types-->stackte tutulur
            // int number1 = 10;
            // int number2 = 20;

            // number1 = number2;
            // number2 = 100;


            //// Console.WriteLine("number2 :" + number2);

            // // arrays, class, interface ... reference types -->heapte tutulur
            // int[] numbers1 = new int[] { 1, 5, 6, 4 };
            // int[] numbers2 = new int[] { 10, 54, 63, 75 };

            // numbers1 = numbers2;
            // numbers2[0] = 1000;

            // /*Console.WriteLine("numbers2[2] = " + numbers2[2] + " " +
            //     "numbers1[2] = " + numbers1[2]); */

            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "caner";
            person1.LastName = "kara";
            person1.Id = 28;

            person2 = person1;
            string name = person1.FirstName = "kadir";
            string name2 = person2.FirstName;

            //console.writeline("firstname = " + name);
            //console.writeline("name2 = " + name2);

            Customer customer = new Customer();
            Employee employee = new Employee();

            customer.FirstName = "deniz";
            customer.CreditCardNumber = 45897645321;

            Person person3 = customer; //kalıtımdan dolayı
            customer.FirstName = "fatime";
            employee.EmployeeNumber = 54;
            //Console.WriteLine(person3.FirstName);
            //Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();

            personManager.Add(customer);
           
            
        }


        class Person //base class - temel sınıf
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class Customer : Person
        {
            public long CreditCardNumber { get; set; }
        }
        class Employee : Person
        {
            public int EmployeeNumber { get; set; }
        }

        class PersonManager
        {
            public void Add(Person person) // böyle bir kullanımda aynı kodu farklı nesneler için kullanılabilir
            {
                Console.WriteLine(person.FirstName); //customer.firstname
                
            }
        }



    }
}
