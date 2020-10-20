using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentPKS student1 = new StudentPKS
            {
                FirstName = "Илья",
                LastName = "Василенко",
                Age = 18,
                GrupNamber = "ПКС1-18"
            }; // конструктор student1
            student1.Print(student1); // вызываем метод Print с параметрами student1

            StudentPKS student2 = new StudentPKS
            {
                FirstName = "Василий",
                LastName = "Петров",
                Age = 19,
                GrupNamber = "ПКС1-17"
            };
            student2.Print(student2); // вызываем метод Print с параметрами student2

            Console.ReadKey();
        }
    }
}
// https://www.youtube.com/watch?v=PUeR3srCtyM

