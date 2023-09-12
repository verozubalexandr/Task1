using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Вариант 19 (Реализация функции возведения в куб суммы двух целых чисел)\n");

            Random rand = new Random();

            int firstNumber = rand.Next(-100, 100);
            int secondNumber = rand.Next(-100, 100);

            Console.WriteLine("(({0}) + ({1}))^3 = {2}\n", firstNumber, secondNumber, CubeTheSum(firstNumber, secondNumber));
        }

        static int CubeTheSum(int firstNumber, int secondNumber) { 
            return (int)Math.Pow(firstNumber + secondNumber, 3);
        }
    }
}
