using System.ComponentModel.DataAnnotations;

namespace Group7Project.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; } 
        public DateTime DateCreate { get; set; } = DateTime.Now;
    }
}
