namespace App19._11.Entities
{
    internal class Employe
    {
        public string Name { get; set; }
        public string Birthday { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Bio { get; set; }
        public string Districts { get; set; }

        public Employe()
        {
            Name = "";
            Birthday = "";
            Phone = "";
            Email = "";
            Bio = "";
            Districts = "";
        }

        public Employe(string name)
        {
            Name = name;
        }
        public Employe(string name, string birthday) : this(name) 
        {
            Birthday = birthday;
        }
        public Employe(string name, string birthday, string phone) : this(name, birthday)
        {
            Phone = phone;
        }
        public Employe(string name, string birthday, string phone, string email) : this(name, birthday, phone)
        {
            Email = email;
        }
        public Employe(string name, string birthday, string phone, string email, string bio) : this(name, birthday, phone, email)
        {
            Bio = bio;
        }
        public Employe(string name, string birthday, string phone, string email, string bio, string districts) : this(name, birthday, phone, email, bio)
        {
            Districts = districts;
        }

        public string Print()
        {
            return $"Ім'я: {Name}\nДень народження: {Birthday}\nТелефон: {Phone}\nЕмейл: {Email}\n Біографія: {Bio}\n Задачі: {Districts}";
        }


    }
}

