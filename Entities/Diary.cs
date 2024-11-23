using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App19._11.Entities
{
    internal class Diary
    {
        public string Name { get; set; }
        public string Year { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        Diary()
        {
            Name = "Default";
            Year = "Default";
            Description = "Default";
            Phone = "Default";
            Email = "Default";
        }

        public Diary(string name) : this()
        {
            Name = name;
        }
        public Diary(string name, string year) : this(name)
        {
            Year = year;
        }
        public Diary(string name, string year, string description) : this(name, year)
        {
            Description = description;
        }
        public Diary(string name, string year, string description, string phone) : this(name, year, description)
        {
            Phone = phone;
        }
        public Diary(string name, string year, string description, string phone, string email) : this(name, year, description, phone)
        {
            Email = email;
        }

        public string GetFullInfo()
        {
            return $"Name: {Name}\nYear: {Year}\nDescription: {Description}\nPhone: {Phone}\nEmail: {Email}";
        }
    }
}
