using Microsoft.Extensions.DependencyModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutmation.Entities.Models
{
    public class Personel
    {
        [Key]
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime BirtDate { get; set; }
        public string? Gender { get; set; }
        [StringLength(6,ErrorMessage ="Parola en fazla on iki karakter olabilir")]
        public string? Password{ get; set; }
        [ForeignKey("Library")]
        public int LibrayId { get; set; }


    }
}
