using System;
using System.Collections.Generic;

namespace HandsOnEFDBFirst.Entities;

public partial class VwEmployeeDeptDetail
{
    public int EmpId { get; set; }

    public string EmpName { get; set; } = null!;

    public string? Designation { get; set; }

    public DateOnly? JoinDate { get; set; }

    public string DeptName { get; set; } = null!;
}
