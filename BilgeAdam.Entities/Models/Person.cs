using BilgeAdam.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Entities.Models
{
    [Table("People")]
    public class Person : EntityBase<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
