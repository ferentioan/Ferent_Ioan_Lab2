using Microsoft.EntityFrameworkCore;
using Ferent_Ioan_Lab2.Data;
using Ferent_Ioan_Lab2.Models;
namespace Ferent_Ioan_Lab2.Data
{
    public class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LibraryContext(serviceProvider.GetRequiredService<DbContextOptions<LibraryContext>>()))
            {
                // Verifică dacă există deja date
                if (context.Book.Any())
                {
                    return; // Baza de date a fost deja creată
                }

                // Creare autori
                var authors = new Author[]
                {
                new Author { FirstName = "Mihail", LastName = "Sadoveanu" },
                new Author { FirstName = "George", LastName = "Calinescu" },
                new Author { FirstName = "Mircea", LastName = "Eliade" }
                };
                context.Author.AddRange(authors);

                // Creare genuri
                var genres = new Genre[]
                {
                new Genre { Name = "Roman" },
                new Genre { Name = "Nuvela" },
                new Genre { Name = "Poezie" }
                };
                context.Genre.AddRange(genres);

                // Creare cărți și asociere cu autori și genuri
                var books = new Book[]
                {
                new Book { Title = "Baltagul", Price = Decimal.Parse("22"), GenreID = 1, AuthorID = 1 },
                new Book { Title = "Enigma Otiliei", Price = Decimal.Parse("18"), GenreID = 1, AuthorID = 2 },
                new Book { Title = "Maytrei", Price = Decimal.Parse("27"), GenreID = 1, AuthorID = 3 }
                };
                context.Book.AddRange(books);

                // Creare clienți
                var customers = new Customer[]
                {
                new Customer { Name = "Popescu Marcela", Adress = "Str. Plopilor, nr. 24", BirthDate = DateTime.Parse("1979-09-01") },
                new Customer { Name = "Mihailescu Cornel", Adress = "Str. Bucuresti, nr. 45, ap. 2", BirthDate = DateTime.Parse("1969-07-08") }
                };
                context.Customer.AddRange(customers);

                // Salvează modificările
                context.SaveChanges();
            }
        }
    }

}

