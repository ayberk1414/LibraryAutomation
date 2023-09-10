using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutmation.DTO.Models
{

    // Kullanıcı gostermek istediğimız kısımları buraya yazıcaz dto gereksiz kısımlar var
    public class AuthorDTO
    {
        [Key]
        public int Id { get; set; }
         public string? FirstName{ get; set; }
         public string? LastName{ get; set; }
        public DateTime BirthDate { get; set; }
    }
}
