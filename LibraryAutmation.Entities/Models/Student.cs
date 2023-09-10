using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutmation.Entities.Models
{
  

public class Student
    {
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Öğrenci adı boş bırakılamaz.")]
        [StringLength(50, ErrorMessage = "Öğrenci adı en fazla 50 karakter olabilir.")]
        public string? StudentName { get; set; }

        [Required(ErrorMessage = "Öğrenci soyadı boş bırakılamaz.")]
        [StringLength(50, ErrorMessage = "Öğrenci soyadı en fazla 50 karakter olabilir.")]
        public string? StudentSurname { get; set; }

        [Required(ErrorMessage = "Parola boş bırakılamaz.")]
        [StringLength(12, ErrorMessage = "Parola en fazla on iki karakter olabilir.")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "TCKN boş bırakılamaz.")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "TCKN 11 karakter olmalıdır.")]
        public string? TCKN { get; set; }
    }
}
   
