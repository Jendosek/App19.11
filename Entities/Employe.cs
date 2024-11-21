namespace App19._11.Entities
{
    internal class Employe
    {
        public string name { get; set; }
        public string birthday { get; set; }
        public string phone { get; set; }
        public string Email { get; set; }
        public string Bio { get; set; }
        public string Districts { get; set; }

        public Employe()
        {
            name = "";
            birthday = "";
            phone = "";
            Email = "";
            Bio = "";
            Districts = "";
        }

        public Employe(string name)
        {
            this.name = name;
        }
        public Employe(string name, string birthday) : this(name) 
        {
            this.birthday = birthday;
        }
        public Employe(string name, string birthday, string phone) : this(name, birthday)
        {
            this.phone = phone;
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
            return $"Ім'я: {name}\nДень народження: {birthday}\nТелефон: {phone}\nЕмейл: {Email}\nБіографія: {Bio}\nЗадачі: {Districts}";
        }


    }
}

