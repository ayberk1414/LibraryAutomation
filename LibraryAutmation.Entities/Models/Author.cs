using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutmation.Entities.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
         public string? FirstName{ get; set; }
         public string? LastName{ get; set; }
        public DateTime BirthDate { get; set; }
    }
}
