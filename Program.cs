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

            Website website = new Website("Google", "google.com", "Search engine", "fdfdfdfd");
        }
    }
}
