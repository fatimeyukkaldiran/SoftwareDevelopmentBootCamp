using System;

namespace MethodPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            string day = "Sunday"; // ref için başlangıç değeri verilmezse problem çıkartır.
            Console.WriteLine("before 'ref' keyword name :" + day);
            GetDay(ref day); // day değişkeninin referansını gönderdi, 
            Console.WriteLine("after 'ref' keyword name :" + day);

            string name = "Java programming"; // string name; olarak da tanımlayabilirdik, out keyword bu şekilde kabul ediyor
            Console.WriteLine("before 'out' keyword name :" + name);
            GetName(out name);    
            Console.WriteLine("after 'out' keyword name : " + name);
        }


        public static void GetDay(ref string day) //metot içinde tanımlanırken de ref verilmeli
        {
            day = DateTime.Now.DayOfWeek.ToString(); //buradaki day değişkinene başka değer atandı 
        }


        public static void GetName(out string name)
        {
            name = "C# programming";
        }

    }
}
