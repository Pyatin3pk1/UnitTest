using MyLib;


namespace DLL_Lib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 5;

            Console.WriteLine("Сложение: " + MathOperations.Add(a, b));
            Console.WriteLine("Вычитание: " + MathOperations.Subtract(a, b));
            Console.WriteLine("Умножение: " + MathOperations.Multiply(a, b));
            Console.WriteLine("Деление: " + MathOperations.Divide(a, b));

        }
    }
}