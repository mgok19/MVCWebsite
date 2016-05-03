// Michael O'Keefe
//
// Book model, a template class for all book objects

using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace BookClubMVC.Models
{
    public class Book
    {
        public int ID { get; set; }


        public string Title { get; set; }
        public string Author { get; set; }

        [Display(Name = "Release Year")]
        public string PublicationYear { get; set; }
        public string Genre { get; set; }

        [Display(Name = "Checked Out To")]
        public string CheckedOutID { get; set; }

    }

    // database of books
    public class BookDBContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }

}