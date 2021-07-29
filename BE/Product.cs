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
        private string name;

        private Double price;

        private Enums.categories category;
        //
        string imagel;
        //public int Pid { get => Id; set => Id = value; }
        public string Name { get => name; set => name = value; }
        public Double Price { get => price; set => price = value; }
        public Enums.categories Category { get => category; set => category = value; }
    }
}
