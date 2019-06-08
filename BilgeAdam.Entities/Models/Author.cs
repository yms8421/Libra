using BilgeAdam.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace BilgeAdam.Entities.Models
{
    public class Author : EntityBase<int>
    {
        [MaxLength(50)]
        public string FullName { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}
