using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BE
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(25)]
        public string name { get; set; }

        public List<Purchase> Purchases { get; set; }

    }
}
