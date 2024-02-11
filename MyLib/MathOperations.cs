namespace MyLib
{
    public static class MathOperations
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            return (double)a / b;
        }
        public static double Pow(double x, double y)
        {
            double result = 1;
            for (double i = 0; i < y; i++)
            {
                result *= x;
            }
            return result;
        }

        public static double Sqrt(double x)
        {
            double res = 1;
            res /= x;
            return res;
        }
    }

}