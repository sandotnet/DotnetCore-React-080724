using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace HandsOnEFDBFirstCRUD.Entities;

public partial class Product
{
    [Required(ErrorMessage ="ID is Required")]
    public int Pid { get; set; }

    [Required(ErrorMessage = "Name is Required")]
    public string Pname { get; set; } = null!;

    [Required(ErrorMessage = "Price is Required")]
    public int? Price { get; set; }

    [Required(ErrorMessage = "Stock is Required")]
    public int? Stock { get; set; }
}
