using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutmation.Entities.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? CategoryName { get; set; }
        public string? Description { get; set; }
    }
}
