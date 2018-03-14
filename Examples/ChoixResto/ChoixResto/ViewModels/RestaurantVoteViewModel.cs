﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ChoixResto.ViewModels
{
    public class RestaurantVoteViewModel : IValidatableObject
    {
        public List<RestaurantCheckBoxViewModel> ListeDesResto { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (!ListeDesResto.Any(r => r.EstSelectionne))
                yield return new ValidationResult("Vous devez choisir au moins un restaurant", new[] { "ListeDesResto" });
        }
    }
}