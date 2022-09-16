namespace While
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number = 1221;
            int temp,remineder, sum = 0;
            temp = number;
            while (number > 0)
            {
                remineder = number % 10;
                sum  = (sum *10) + remineder;
                number = number / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine($"{temp} is Palindrome");
            }
            else
            {
                Console.WriteLine ($"{temp} is not Palindrome");
            }
        }
    }
}