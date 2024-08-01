using System;
using System.Collections.Generic;

namespace HandsOnEFDBFirstCRUD.Entities;

public partial class EmployeeDetail
{
    public int EmpId { get; set; }

    public string EmpName { get; set; } = null!;

    public string? DeptCode { get; set; }

    public string? Designation { get; set; }

    public DateOnly? JoinDate { get; set; }

    public int? Manager { get; set; }

    public virtual Department? DeptCodeNavigation { get; set; }
}
