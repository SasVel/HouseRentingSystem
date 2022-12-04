using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HouseRentingSystem.Infrastructure.Data.Models
{
    public class House
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MaxLength(150)]
        public string Address { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        [MaxLength(300)]
        public string ImageUrl { get; set; }

        [Required]
        [Column(TypeName = "money")]
        [Precision(18, 2)]
        public decimal PricePerMonth { get; set; }

        [Required]
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Required]
        [ForeignKey(nameof(Agent))]
        public int AgentId { get; set; }
        public Agent Agent { get; set; }

        
        [ForeignKey(nameof(Renter))]
        public string? RenterId { get; set; }
        public IdentityUser? Renter { get; set; }

    }
}
