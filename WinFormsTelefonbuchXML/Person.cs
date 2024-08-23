using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WinFormsTelefonbuchXML
{
    [Serializable]
    public class Person
    {
        public string Forename { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }



        public Person(string forename, string name, string phone, string email)
        {
            Forename = forename;
            Name = name;
            Phone = phone;
            Email = email;
            CreatedAt = DateTime.Now;
        }

        public override string ToString()
        {
            return String.Format("Vorname: {0}\nName: {1}\nTelefon: {2}\nEmail: {3}\nErstellt am: {4:dd.MM.yyyy}",
                    Forename,
                    Name,
                    Phone,
                    Email,
                    CreatedAt);
        }
    }
}
