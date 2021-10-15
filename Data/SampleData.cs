using System.Collections.Generic;
using Lab04.Models;

namespace Lab04.Data
{
   public class SampleData {
    public static List<Province> GetProvinces() {
      List<Province> provinces = new List<Province>() {
         new Province() {
		     ProvinceCode = "BC",
             ProvinceName="British Columbia",
         },
		  new Province() {
		     ProvinceCode = "SK",
             ProvinceName="Saskatchewan",
         },
		  new Province() {
		     ProvinceCode = "ON",
             ProvinceName="Ontario",
         },
		 
		 
         
      };

      return provinces;
  }

  public static List<City> GetCities() {
      List<City> cities = new List<City>() {
         new City {
             CityId = 1,
             CityName = "Vancouver",
             Population = 631486, 
             ProvinceCode = "BC",
         },
		  new City {
             CityId = 2,
             CityName = "Victoria",
             Population = 367770, 
             ProvinceCode = "BC",
         },
		  new City {
             CityId = 3,
             CityName = "Kamloops",
             Population = 100046, 
             ProvinceCode = "BC",
         },
		  new City {
             CityId = 4,
             CityName = "Regina",
             Population = 236481, 
             ProvinceCode = "SK",
         },
		  new City {
             CityId = 5,
             CityName = "Saskatoon",
             Population = 336614, 
             ProvinceCode = "SK",
         },
		  new City {
             CityId = 6,
             CityName = "Moose Jaw",
             Population = 33274, 
             ProvinceCode = "SK",
         },
		  new City {
             CityId = 7,
             CityName = "Toronto",
             Population = 6417516, 
             ProvinceCode = "ON",
         },
		  new City {
             CityId = 8,
             CityName = "Ottawa",
             Population = 934243, 
             ProvinceCode = "ON",
         },
		  new City {
             CityId = 9,
             CityName = "Windsor",
             Population = 217188, 
             ProvinceCode = "ON",
         },
		  
		 
		 
         
      };

      return cities;
  }

}

}