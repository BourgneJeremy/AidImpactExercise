using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AidImpactExercise.Models
{
    public class Point
    {
        [Display(Name = "City name")]
        [Required]
        [StringLength(50, MinimumLength = 3,
            ErrorMessage = "The name of the city must contains between 3 and 50 caracters")]
        public string Name { get; set; }

        [Display(Name = "City longitude")]
        [Required]
        public double Longitude { get; set; }

        [Display(Name = "City latitude")]
        [Required]
        public double Latitude { get; set; }
    }
}
