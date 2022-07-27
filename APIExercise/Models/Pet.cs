using System;
using System.Collections.Generic;

namespace APIExercise.Models
{
    public partial class Pet
    {
        public int Id { get; set; }
        public string? PetName { get; set; }
        public int? CategoryId { get; set; }
        public int? Age { get; set; }
        public double? Price { get; set; }

        public virtual Category? Category { get; set; }
    }
}
