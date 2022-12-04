using System.ComponentModel.DataAnnotations;

namespace HouseRentingSystem.Infrastructure.Data.Models
{
    public class Category
    {
        public Category()
        {
            Houses = new List<House>(); 
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public List<House> Houses { get; set; }
    }
}
