﻿using BeeShopMVC.Data.Interfaces;
using System.ComponentModel.DataAnnotations;
using static BeeShopMVC.Data.DataConstants.Honey;
namespace BeeShopMVC.Data.Models
{
    public class Honey : IHoney
    {
        public int Id { get; init; }
        [Required]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; }
        [Required]
        [MaxLength(MaxDescriptionLength)]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
