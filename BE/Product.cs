using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(25)]
        public string name { get; set; }

        public Double price { get; set; }

        public Enums.categories category { get; set; }
       
    }
}
