using System;
using System.Collections.Generic;

namespace Ferent_Ioan_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string FirstName { get; set; } = string.Empty; // Valoare implicită pentru a evita null
        public string LastName { get; set; } = string.Empty;  // Valoare implicită pentru a evita null

        // FullName formatat corect
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}".Trim(); // Adaugă spațiu între prenume și nume
            }
        }

        // Relație cu cărțile
        public ICollection<Book>? Books { get; set; }
    }
}
