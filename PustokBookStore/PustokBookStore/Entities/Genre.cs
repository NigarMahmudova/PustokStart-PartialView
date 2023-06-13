using System.ComponentModel.DataAnnotations;

namespace PustokBookStore.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
    }
}
