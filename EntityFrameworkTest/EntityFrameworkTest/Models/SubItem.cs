
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkTest.Models
{
    public class SubItem
    {
        public SubItem()
        {

        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
