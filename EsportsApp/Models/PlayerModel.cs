using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EsportsApp.Models
{
    [Table("tbl_Player")]
    public class PlayerModel
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
    }
}
