using BilgeAdam.Core;
using BilgeAdam.Enums;
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
        [MaxLength(20)]
        public string ISBNNumber { get; set; }
        public BookCategory Category { get; set; }
        public int? AuthorId { get; set; }

        [ForeignKey(nameof(AuthorId))]
        public virtual Author Author { get; set; }
    }
}
