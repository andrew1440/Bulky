using System.ComponentModel.DataAnnotations;

namespace Bulky_Book2.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public int AddressofStudent { get; set; }
        public bool City { get; set; }
        
    }
}
