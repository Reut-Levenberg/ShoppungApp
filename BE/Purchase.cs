using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BE
{
    [Table("Purchases")]
    public class Purchase
    {
        [Key]
        public int Id { get; set; }
        public User user { get; set; }
        public SoppingList soppingList { get; set; }

        [ForeignKey("SoppingList")]
        public int ListId;
        public store store { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
