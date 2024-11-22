using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App19._11.Entities
{
    internal class Palindrome
    {
        public static string IsPalindrome(int number)
        {
            int reversedNumber = 0;
            int temp = number;
            while (temp > 0)
            {
                int remainder = temp % 10;
                reversedNumber = reversedNumber * 10 + remainder;
                temp /= 10;
            }
            return number == reversedNumber ? $"Число {number} є паліндромом" : $"Число {number} не є паліндромом";
        }
    }
}
