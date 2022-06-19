using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TechnicalTest.Models
{
    public class TblBook
    {
        [Key]
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public int ReleaseYear { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}