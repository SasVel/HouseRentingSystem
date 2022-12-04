using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRentingSystem.Infrastructure.Data.Models
{
    public class Agent
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(15)]
        public string PhoneNumber { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
    } 
}
