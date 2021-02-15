using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HomeWork7.Entities
{
    /// <summary>
    /// Модель студент
    /// </summary>
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public int Course { get; set; }

        public string Description { get; set; }

        public int Mark { get; set; }
    }
}
