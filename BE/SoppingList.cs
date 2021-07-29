using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BE
{
    [Table("SoppingLists")]
    public class SoppingList
    {
        [Key]
        public int Id { get; set; }

        private List<Product> products;

       // public int Lid { get => Id; set => Id = value; }
        public List<Product> Products { get => products; set => products = value; }
    }
}
