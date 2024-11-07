using System;

namespace WebApplication1.Models;

public class Item
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public DateTimeOffset CreatedDate { get; set; }
}
