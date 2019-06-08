using BilgeAdam.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BilgeAdam.Entities.Models
{
    [Table("Shelves")]
    public class Shelve : EntityBase<string>
    {
        [MaxLength(5)]
        [Key]
        public new string Id { get; set; }
    }
}
