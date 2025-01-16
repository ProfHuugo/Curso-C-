using System;

namespace Course.Entities
{
    class Client
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }


        public Client()
        {

        }


        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return Name
            + ", ("
            + BirthDate.ToString("dd/MM?yyyy")
            + ") - "
            + Email;
        }

    }
}