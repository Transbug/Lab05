
using System.Collections.Generic;
using System.ComponentModel.Design;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Lab04.Data;

namespace Lab04.Models
{
 public class City {
     

   public int CityId        { get; set; } 

   [Required]  
   [Display (Name = "City")]
   [MaxLength (35)]
   public string CityName   { get; set; }
   public int Population    { get; set; }

   [Display (Name = "Province")]
   public string ProvinceCode { get; set; }

   [ForeignKey("ProvinceCode")]
   public Province Province { get; set; }

 }  

}