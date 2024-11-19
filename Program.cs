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

            City city = new City();
            City city = new City(cityName = "Вінниця" );
        }
    }
}
