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

            Console.Write("Введіть число: ");
            int number = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(Palindrome.IsPalindrome(number));
        }
    }
}
