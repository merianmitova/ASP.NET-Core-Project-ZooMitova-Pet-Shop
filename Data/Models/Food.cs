namespace ZooMitova_Pet_Shop.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static DataConstants;

    public class Food
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        public double Price { get; set; }
        [Required]
       
        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public int Stock { get; set; } 
       
        public double PackageSize { get; set; } 

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
