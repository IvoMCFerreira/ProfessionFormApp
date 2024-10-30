using System.ComponentModel.DataAnnotations;

namespace PersonProfessionApp.Models
{
    public class Profession
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;

        public List<Person> People { get; set; } = new List<Person>();
    }
}
