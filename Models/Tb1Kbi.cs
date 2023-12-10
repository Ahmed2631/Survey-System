using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Survey_System.Models
{
    public partial class Tb1Kbi
    {
        [ValidateNever]
        [Key]
        public int DepNo { get; set; }
        [ValidateNever]
        public int Kpidnum { get; set; }
        [ValidateNever]
        public bool MeasurementUnit { get; set; } = false;
        [MaxLength(150)]
        [Required(ErrorMessage = "Enter Description,Please")]
        public string Kpidescription { get; set; } = null!;
        //[MaxLength(3)]
        [Required(ErrorMessage = "Enter Value,Please")]
        public int TargetedValue { get; set; }
    }
}
