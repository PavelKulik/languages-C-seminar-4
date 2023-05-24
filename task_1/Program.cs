internal class Program_1
{
    private static void Main(string[] args)
    {
        int Exponentiation(int number, int extent)
        {
            int exp = 1;
            for (int i = 1; i <= extent; i++) { exp *= number; }
            return exp;
        }

        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine()!);
        Console.Write("Введите степень числа: ");
        int extent = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"Число {number}^{extent} = {Exponentiation(number, extent)}");

    }
}