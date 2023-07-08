using System.Collections.Generic;

namespace ZooMitova_Pet_Shop.Data.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<Food> Foods { get; set; } = new List<Food>(); 
    }
}
