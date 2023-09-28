using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3CityProvince.Models
{
    public class City
    {
        [Key]
        public int? CityId { get; set; }

        public string? CityName { get; set; }

        public int? Population { get; set; }

        public string? ProvinceCode { get; set; } // Correct data type

        [ForeignKey("ProvinceCode")]
        public Province? Province { get; set; }
    }
}
