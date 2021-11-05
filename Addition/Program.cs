using System;
//Используя Visual Studio, создайте проект по шаблону Console Application. 
//Требуется:
//Создать статический класс Calculator, с методами для выполнения основных арифметических 
//операций. Написать программу, которая выводит на экран основные арифметические операции.

namespace Addition
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.Div(12, 2);
            Calculator.Sum(16, 34);
            Calculator.Sub(13, 9);
            Calculator.Mult(22, 3);
            Calculator.Div(17, 17);
            Calculator.Div(20, 10);

            Console.ReadKey();
        }
    }
}
