using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_Model.Models
{
    public class BookDetail
    {
        [Key]
        public int BookDetail_Id { get; set; }
        public int NumberOfChapter { get; set; }
        public int NumberOfPages { get; set; }
        public double Weight { get; set; }
    }
}
