internal class Program
{
    private static void Main(string[] args)
    {
        int SumNumber(int number)
        {
            int sum = 0;
            while(number > 0)
            {
                sum += number % 10;
                number = number / 10;
            }
            return sum;
        }

        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"{number} -> {SumNumber(number)}");
    }
}