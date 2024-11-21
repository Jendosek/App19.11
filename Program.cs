using System.Text;
using App19._11.Entities;

namespace App19._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Employe employe = new Employe();
            Employe employe2 = new Employe("Женя", "20.11.2006", "0688170771", "bala01081977@gmail.com", "software developer with 0 years of work", "deze");
            Console.WriteLine(employe2.Print());

        }
    }
}
