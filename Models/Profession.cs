using System.ComponentModel.DataAnnotations;

namespace PersonProfessionApp.Models
{
    public class Profession
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public List<Person> People { get; set; } = new List<Person>();
    }
}
