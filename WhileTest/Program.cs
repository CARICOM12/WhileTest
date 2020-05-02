using System;

namespace WhileTest
{
    /*На вход идут числа
     * На выход - их квадратные корни
     * Как только найдено отрицательное число или 
     * некорректный ввод числа - завершение программы
     * 
     * 1. Вводится число
      2.1. Если число > 0 - вывод
      2.2. Иначе - завершение
      3. Переход к 1. */



    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a number ");
            int number = Convert.ToInt32(Console.ReadLine());
            while(number > 0)
            {
                Console.WriteLine(Math.Sqrt(number) + " ");
                Console.Write("Please enter a number ");
                number = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
