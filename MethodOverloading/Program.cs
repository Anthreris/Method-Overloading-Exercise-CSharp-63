namespace MethodOverloading
{
    public class Program
    {

        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static decimal Add(decimal numOne, decimal numTwo)
        {
            return numOne + numTwo;
        }

        public static string Add(int numOne, int numTwo, bool isCurrency) // Struggled at this part
        {
            var sum = numOne + numTwo;

            if (isCurrency && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isCurrency && sum == 1)
            {
                return $"{sum} dollar";
            }
            else
            {
                return sum.ToString();
            }
        }
        
        static void Main(string[] args)
        {
            var answer = Add(1, 0, isCurrency: true);
            var decimalAnswer = Add(3, 3, isCurrency: true);
            var trueAnswer = Add(1, 3, isCurrency: true);
            var falseAnswer = Add(1, 1, isCurrency: false);

            Console.WriteLine($"int Add: {answer}, decimal Add: {decimalAnswer}.");
            Console.WriteLine(trueAnswer);
            Console.WriteLine(falseAnswer);
        }
    }
}
