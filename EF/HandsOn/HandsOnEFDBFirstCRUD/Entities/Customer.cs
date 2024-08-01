using System;
using System.Collections.Generic;

namespace HandsOnEFDBFirstCRUD.Entities;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? CustomerName { get; set; }
}
