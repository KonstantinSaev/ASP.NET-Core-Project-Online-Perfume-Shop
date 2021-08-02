﻿using System.ComponentModel.DataAnnotations;
using static OnlinePerfumeShop.Data.DataConstants;

namespace OnlinePerfumeShop.Data.Models
{
    public class Perfume
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(PerfumeNameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(PerfumeDesctriptiondMaxLength)]
        public string Desctription { get; set; }

        [Range(PerfumeMinPrice, PerfumeMaxPrice)]
        public decimal Price { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public int Qunatity { get; set; }

        public string AddedByUserId { get; set; }
        public User AddedByUser { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public int BrandId { get; set; }

        public Brand Brand { get; set; }
    }
}
