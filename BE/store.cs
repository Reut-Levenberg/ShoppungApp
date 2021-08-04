using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BE
{
    [Table("Stores")]
    public class store
    {
        [Key]
        public int Id { get;set; }

        public String storeName { get; set; }
    }
}
