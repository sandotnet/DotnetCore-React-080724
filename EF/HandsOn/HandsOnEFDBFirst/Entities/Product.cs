using System;
using System.Collections.Generic;

namespace HandsOnEFDBFirst.Entities;

public partial class Product
{
    public int Pid { get; set; }

    public string Pname { get; set; } = null!;

    public int? Price { get; set; }

    public int? Stock { get; set; }
}
