using System;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkTest.Models
{
    public class Item
    {
        public Item()
        {

        }

        [Key]
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
    }
}