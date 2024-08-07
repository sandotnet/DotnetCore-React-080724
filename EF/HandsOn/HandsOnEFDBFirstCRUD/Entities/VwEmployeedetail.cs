using System;
using System.Collections.Generic;

namespace HandsOnEFDBFirstCRUD.Entities;

public partial class VwEmployeedetail
{
    public int EmpId { get; set; }

    public string EmpName { get; set; } = null!;

    public string? Designation { get; set; }
}
