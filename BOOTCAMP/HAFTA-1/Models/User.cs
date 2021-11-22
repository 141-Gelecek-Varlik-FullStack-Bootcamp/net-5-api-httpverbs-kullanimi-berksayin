using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HAFTA_1.Models
{
    public class User
    {
        [Required]
        [Key]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int Id { get; set; }

        [Required]
        [StringLength(8, ErrorMessage = "Karakter sayısı 8'den büyük olamaz!")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string UserEmail { get; set; }
    }
}
