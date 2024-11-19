using App19._11.Entities;

namespace App19._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть елементи масиву через пробіл:");
            string[] input = Console.ReadLine().Split(' ');
            int[] array = Array.ConvertAll(input, int.Parse);
        }
    }
}
