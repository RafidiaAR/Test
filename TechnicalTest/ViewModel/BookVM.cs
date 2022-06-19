using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TechnicalTest.ViewModel
{
    public class BookVM
    {
        public int BookId { get; set; }

        [DisplayName("Book Name")]
        [Required]
        public string BookName { get; set; }
        
        [Required]
        public string Author { get; set; }
        
        [DisplayName("Release Year")]
        public int ReleaseYear { get; set; }
        
        public DateTime CreatedDate { get; set; }
    }
}