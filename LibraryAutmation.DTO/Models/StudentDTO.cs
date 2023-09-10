using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutmation.DTO.Models

{
    public class StudentDTO
    {
        public int StudentId { get; set; }
        public string? StudentName { get; set; }
        public string? StudentSurname { get; set; }

        [StringLength(12,ErrorMessage = "Parola en fazla on iki karakter olabilir.")]


        public string? Password { get; set; }
        [StringLength(11, MinimumLength = 11, ErrorMessage = "TCKN 11 karakter olmalıdır.")]
        public string? TCKN { get; set; }
    }
}
