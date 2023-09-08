using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryMangement.Models
{
    public class BookDetailModel
    {
        [Key]
        public int BookId { get; set; }
        public string BookName { get; set; } 
        public string Genre { get; set; }
        public string Author { get; set; }
    }
}