using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Streja_Raluca_Lab2.Models
{
    public class Publisher
    {
        public int ID { get; set; }

        [Display(Name = "Publisher Name")]
        public string PublisherName { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}
