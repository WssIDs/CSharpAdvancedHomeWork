using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace HomeWork9.Entities
{
    [Index(nameof(FirstName), nameof(LastName))]
    public class Author
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string AlterName { get; set; }

        public ICollection<Story> Stories { get; set; }
    }
}
