using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AidImpactExercise.Models
{
    public class Point
    {
        // Code allowing to define what Entity Framework needs
        public long Id { get; set; }

        private string _key;

        public string Key
        {
            get
            {
                if (_key == null)
                {
                    _key = Regex.Replace(Name.ToLower(), "[^a-z0-9]", "-");
                }
                return _key;
            }
            set { _key = value; }
        }

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
