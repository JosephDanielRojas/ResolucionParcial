using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RecuperacionDaniel.Models
{
    public class Product
    {
        [Key]
        [Range(1,99999)]
        public int ProductID { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Ingrese entre 3 y 30 caracteres")]
        public string Description { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime LastBuy { get; set; }
    }
}