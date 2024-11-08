// Models/Item.cs
using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Item
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "The Name field is required.")]
        public required string Name { get; set; } // Using 'required' modifier
    }
}