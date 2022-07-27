using System;
using System.Collections.Generic;

namespace APIExercise.Models
{
    public partial class Category
    {
        public Category()
        {
            Pets = new HashSet<Pet>();
        }

        public int Id { get; set; }
        public string? CategoryName { get; set; }

        //[System.Text.Json.Serialization.JsonIgnore]
        public virtual ICollection<Pet> Pets { get; set; }
    }
}
