﻿namespace DesAppMVC.Models;

public partial class Product
{
    public int IdProduct { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public double? Price { get; set; }

    public int? IdType { get; set; }

    public virtual Type? IdTypeNavigation { get; set; }
}
