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
        private string name;

        private List<SoppingList> soppingLists;

        //public int Uid { get => Id; set => Id = value; }
        public string Name { get => name; set => name = value; }
        public List<SoppingList> SoppingLists { get => soppingLists; set => soppingLists = value; }
    }
}
