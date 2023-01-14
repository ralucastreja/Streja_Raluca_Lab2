using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Streja_Raluca_Lab2.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Display(Name = "Book Title")]
        public string Title { get; set; }
        public string Author { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }

        [Display(Name = "Publishing Date")]
        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }
        public int PublisherID { get; set; }
        public Publisher Publisher { get; set; }
        public ICollection<BookCategory> BookCategories { get; set; }
    }
}
