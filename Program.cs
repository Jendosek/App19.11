using App19._11.Entities;
using System.Text;

namespace App19._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Введіть елементи масиву через пробіл:");
            string[] input = Console.ReadLine().Split(' ');
            int[] array = Array.ConvertAll(input, int.Parse);

            Console.WriteLine("Оберіть порядок сортування: 'asc' для зростання, 'desc' для зменшення:");
            string order = Console.ReadLine();

            BubbleSorter sorter = new BubbleSorter();
            sorter.Sort(array, order);

            Console.WriteLine("Відсортований масив:");
            Console.WriteLine(string.Join(" ", array));

        }
    }
}
