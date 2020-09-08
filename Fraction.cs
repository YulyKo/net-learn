using System;

namespace net_learn
{
    class Fraction
    {
        // Реалізувати клас дріб. Необхідно зберігати чисельник і знаменник в якості змінних- членів. 
        // Реалізувати функції- члени для введення даних в змінні- члени, для виконання арифметичних операцій (+ - * ...)

        static int numerator; // чисельник
        static int denominator = 34; // знаменник

        static void Main(string[] args)
        {
            GetNumerator();
            GetDenominator();
            CalculateSum();
            CalculateDifference();
            CalculateProduct();
            CalculateDivide();
            Console.WriteLine("Hello World!");
        }

        static void GetNumerator()
        {
            Console.Write("Enter numerator: ");
            string val = Console.ReadLine();
                
            numerator = Convert.ToInt32(val);
        }

        static void GetDenominator()
        {
            Console.Write("Enter denominator: ");
            string val = Console.ReadLine();
                
            denominator = Convert.ToInt32(val);
        }

        static void CalculateSum()
        {
            int sum = numerator + denominator;
            Console.WriteLine("Sum : " + sum);
        }

        static void CalculateDifference()
        {
            int sum = numerator - denominator;
            Console.WriteLine("Difference : " + sum);
        }

        static void CalculateProduct()
        {
            int product = numerator * denominator;
            Console.WriteLine("Product : " + product);
        }

        static void CalculateDivide()
        {
            int divide = numerator / denominator;
            Console.WriteLine("Divide : " + divide);
        }
    }
    
}
