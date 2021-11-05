using System;
//Задание 3
//Используя Visual Studio, создайте проект по шаблону Console Application. 
//Требуется: создать расширяющий метод для целочисленного массива, который сортирует элементы 
//массива по возрастанию

namespace Task_3
{
    static class Extension
    {
        // пузырьковый метод, нашел в интернете
        public static void SortArray(this int[] array)
        {
            bool sorted = false;
            int temp;
            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        sorted = false;
                    }
                }
            }
            Console.WriteLine("Elements of array sorted");
            Console.WriteLine(new string('-', 20));
        }

        public static void ShowItems(this int[] array) 
        {
            Console.WriteLine("Show elements of array:");
            for (int i = 0; i < array.Length; i++) {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\n" + new string('-', 20));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 2, 7, 3, 9, 8, 5, 3, 4, 6, 2 };
            
            test.ShowItems();
            test.SortArray();
            test.ShowItems();

            Console.ReadKey();
        }
    }
}
