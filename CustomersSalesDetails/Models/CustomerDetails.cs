using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CustomersSalesDetails.Models
{
    public class CustomerDetails
    {
        [Key]
        [Column(TypeName ="int")]
        public int Customer_Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Customer_Name { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Address { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int Mobile { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int AllowDiscount { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int Total_Cradit { get; set; }
    }
}
