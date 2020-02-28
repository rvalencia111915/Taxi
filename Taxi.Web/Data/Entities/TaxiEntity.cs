﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Taxi.Web.Data.Entities
{
    public class TaxiEntity
    {
        public int ID { get; set; }

        [StringLength(6, MinimumLength = 6, ErrorMessage = "The {0} field must have {1} characters.")]
        [RegularExpression(@"^([A-Za-z]{3}\d{3})$", ErrorMessage = "The field {0} must starts whit three characters and ends whit three numbers.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string Plaque { get; set; }

        public ICollection<TripEntity> Trips { get; set; }

    }
}
