using BilgeAdam.Core;
using System;

namespace BilgeAdam.Entities.Models
{
    public class Staff : EntityBase<int>
    {
        public DateTime HireDate { get; set; }
        public string FullName { get; set; }
    }
}
