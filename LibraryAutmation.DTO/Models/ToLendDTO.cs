using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutmation.DTO.Models

{
    public class ToLendDTO
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("PersonelId")]
        public int PersonelId { get; set; }

        [ForeignKey("BookId")]
        public int BookId { get; set; }

        [Required]
        public DateTime LendDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public DateTime TargetDate { get; set; }
    }
}
