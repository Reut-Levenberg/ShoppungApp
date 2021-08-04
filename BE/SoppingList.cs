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

        public List<Product> products { get; set; }

    }
}
