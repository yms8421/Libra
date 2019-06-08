using System;
using System.ComponentModel.DataAnnotations;

namespace BilgeAdam.Core
{
    public class EntityBase<T>
    {
        [Key] 
        public T Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool IsActive { get; set; }
    }
}
