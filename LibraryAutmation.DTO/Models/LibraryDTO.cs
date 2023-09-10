using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutmation.DTO.Models

{
    public class LibraryDTO
    {
        [Key]
        public int Id { get; set; }
        public int FoundingYear { get; set; }
        public string? LibraryName { get; set; }
        public string? Location { get; set; }
        public string? Website { get; set; }
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        public string? ContactEmail { get; set; }
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Telefon numarası 11 karakter olmalıdır.")]
        
        public string? PhoneNumber { get; set; }
       
    }
}
