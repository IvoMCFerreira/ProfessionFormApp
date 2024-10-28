using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonProfessionApp.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int Age { get; set; }

        public int? ProfessionId { get; set; }

        [ForeignKey("ProfessionId")]
        public Profession Profession { get; set; }
    }
}
