using System.Collections.Generic;
using System.ComponentModel.Design;
using System.ComponentModel.DataAnnotations;
using System;

namespace Lab04.Models
{
   public class Province {
    
     
    [Required]       
    [MaxLength (2)]
    [Display (Name = "Province code")]
    [Key]
    public string ProvinceCode { get; set; }
    [Required]  
    [Display (Name = "Province")]
    [MaxLength (35)]
	public string ProvinceName { get; set;}

    public List<City> Cities   { get; set; }
 
    }
}