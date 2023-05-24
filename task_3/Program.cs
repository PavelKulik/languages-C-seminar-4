internal partial class Program
{
    private static void Main(string[] args)
    {
        int[] GetArray(int size)
        {
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Введите элемен массива {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            return array;
        }

        void PrintArray(int[] array)
        {
            Console.Write("[");
            foreach(int el in array)
            {
                Console.Write($"{el} ");
            }
            Console.WriteLine("]");
        }

        int[] array = GetArray(8);
        PrintArray(array);
    }
}