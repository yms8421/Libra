using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BilgeAdam.Core
{
    public class EntityBase<T>
    {
        public EntityBase()
        {
            Created = DateTime.Now;
            Modified = DateTime.Now;
            IsActive = true;
        }
        [Key] 
        public T Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool IsActive { get; set; }
    }
}
