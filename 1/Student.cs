using System;
using System.Collections.Generic;
using System.Text;

namespace _1
{
    

    class StudentPKS
    {
        public string FirstName; // поле класса
        public string LastName; // поле класса
        public int Age; // поле класса
        public string GrupNamber; // поле класса
        public void Print(StudentPKS student) // метод класса
        {
            Console.WriteLine($"{GrupNamber} {student.FirstName} {student.LastName} {student.Age} ");
        }
    }
}
