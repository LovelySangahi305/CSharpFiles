using System;
using System.Collections.Generic;

namespace WebApp1_day20.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public double ProductPrice { get; set; }

    public string Category { get; set; } = null!;
}
