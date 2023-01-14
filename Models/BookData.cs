using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Streja_Raluca_Lab2.Models
{
    public class BookData
    {
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<Category> Categories { get; set; }

        [Display(Name = "Book Categories")]
        public IEnumerable<BookCategory> BookCategories { get; set; }
    }
}
