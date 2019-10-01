using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CustomersSalesDetails.Models
{
    public class InvoicTwo
    {

        [Key]
        [Column(TypeName = "int")]
        public int Invoice_Id { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int Customer_Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Item_Id { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int Quanty { get; set; }

        [Required]
        [Column(TypeName ="int")]
        public int Price { get; set; }

    }
}
