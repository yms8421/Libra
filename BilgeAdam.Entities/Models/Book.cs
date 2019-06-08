using BilgeAdam.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BilgeAdam.Entities.Models
{
    [Table("Books")]
    public class Book : EntityBase<int>
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public int PageCount { get; set; }
    }
}
