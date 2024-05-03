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

        public static string Add(int numOne, int numTwo, bool isCounterfeit)
        {
            int sum = numOne + numTwo;
            if (isCounterfeit == true && sum > 1)
            {
                return $"{sum} dollars are counterfeit";
            }
            else if(isCounterfeit == true && sum == 1)
            {
                return $"{sum} dollar is counterfeit";
            }
            else
            {
                return "None of the money is counterfeit";
            }
        }

        static void Main(string[] args)
        {

            var sumOne = Add(3, 3);
            Console.WriteLine(sumOne);

            var sumTwo = Add(4.6m, 6.7m);
            Console.WriteLine(sumTwo);
            
            var totalCounterfeit = Add(0, 1, true);
            Console.WriteLine(totalCounterfeit);
        }
    }
}
