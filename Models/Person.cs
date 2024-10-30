using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonProfessionApp.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Range(18, int.MaxValue, ErrorMessage = "Age must be 18 or older.")]
        public int Age { get; set; }

        public int? ProfessionId { get; set; }

        [ForeignKey("ProfessionId")]
        public Profession? Profession { get; set; }
    }
}
