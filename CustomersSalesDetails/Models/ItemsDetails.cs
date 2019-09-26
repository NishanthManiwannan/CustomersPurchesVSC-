using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CustomersSalesDetails.Models
{
    public class ItemsDetails
    {
        [Key]
        [Column(TypeName="int")]
        public int Item_Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string ItemName { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Brand { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int Cost { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int Price { get; set; }
    }
}
