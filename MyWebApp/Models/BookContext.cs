using System.Data.Entity;

namespace MyWebApp.Models
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public DbSet<Purchase> Purchases { get; set; }
    }

    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "12 стульев", Author = "И. Ильф, Е. Петров", Price = 700 });
            db.Books.Add(new Book { Name = "Путь меча", Author = "Г.Л. Олди", Price = 450 });
            db.Books.Add(new Book { Name = "Linux: администрирование и системное программирование", Author = "М. Собель", Price = 1500 });
            db.Books.Add(new Book { Name = "Гибель богов", Author = "Н. Перумов", Price = 550 });
            db.Books.Add(new Book { Name = "Черный человек",  Author = "В. Головачев", Price = 330 });

            base.Seed(db);


        }
    }
}