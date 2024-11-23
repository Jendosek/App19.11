using App19._11.Entities;

namespace App19._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary("Diary", "2021", "This is a diary", "123456789", ":)");
            Console.WriteLine(diary.GetFullInfo());
        }
    }
}
