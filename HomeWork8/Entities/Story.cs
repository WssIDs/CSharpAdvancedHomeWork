using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HomeWork8.Entities
{
    public class Story
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Character> Characters { get; set; }

        public ICollection<Author> Authors { get; set; }
    }
}
