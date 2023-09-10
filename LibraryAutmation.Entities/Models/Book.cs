using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutmation.Entities.Models
{
    public class Book
    {
        
            [Key]
            public int Id { get; set; }
            public string? Title { get; set; }

            [ForeignKey("AuthorId")]
            public int AuthorId { get; set; }

            public int PublicationYear { get; set; }

            [ForeignKey("LibraryId")]
            public int LibraryId { get; set; }

            [ForeignKey("CategoryId")]
            public int CategoryId { get; set; }

            public int Quantity { get; set; }

            [ForeignKey("StudentId")]
            public int StudentId { get; set; }
        }






    
}
