using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CustomersSalesDetails.Models
{
    public class Invoice
    {
        [Key]
        [Column(TypeName = "int")]
        public int Invoice_Id { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int Customer_Id { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int Item_Id { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int Quanty { get; set; }


    }
}
