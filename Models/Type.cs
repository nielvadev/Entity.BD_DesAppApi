using System;
using System.Collections.Generic;

namespace DesAppMVC.Models;

public partial class Type
{
    public int IdType { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Product> Productos { get; set; } = new List<Product>();
}
