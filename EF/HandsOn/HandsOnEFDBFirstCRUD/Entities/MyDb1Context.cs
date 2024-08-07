using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using HandsOnEFDBFirstCRUD.ViewModel;

namespace HandsOnEFDBFirstCRUD.Entities;

public partial class MyDb1Context : DbContext
{
    public MyDb1Context()
    {
    }

    public MyDb1Context(DbContextOptions<MyDb1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<EmployeeDetail> EmployeeDetails { get; set; }

    public virtual DbSet<Gender> Genders { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<VwEmployeeDeptDetail> VwEmployeeDeptDetails { get; set; }

    public virtual DbSet<VwEmployeedetail> VwEmployeedetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-4O1D65I\\SQLEXPRESS;Initial Catalog=MyDB1;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Customer__B611CB7DD6CCAF12");

            entity.ToTable("Customer");

            entity.Property(e => e.CustomerId).HasColumnName("customerId");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("customerName");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DeptCode).HasName("dept_pk");

            entity.ToTable("Department");

            entity.HasIndex(e => e.DeptName, "UQ__Departme__B744FF0F773B7270").IsUnique();

            entity.Property(e => e.DeptCode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Dept_Code");
            entity.Property(e => e.DeptName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Dept_Name");
        });

        modelBuilder.Entity<EmployeeDetail>(entity =>
        {
            entity.HasKey(e => e.EmpId).HasName("PK__Employee__AF2DBA797FD4691A");

            entity.Property(e => e.EmpId)
                .ValueGeneratedNever()
                .HasColumnName("EmpID");
            entity.Property(e => e.DeptCode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Dept_Code");
            entity.Property(e => e.Designation)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.DeptCodeNavigation).WithMany(p => p.EmployeeDetails)
                .HasForeignKey(d => d.DeptCode)
                .HasConstraintName("employee_fk01");
        });

        modelBuilder.Entity<Gender>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Gender");

            entity.Property(e => e.Gender1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("gender");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Pid).HasName("PK__Product__C5705938F7DB4DFA");

            entity.ToTable("Product");

            entity.HasIndex(e => e.Pname, "UQ__Product__42B46083E18AC0FB").IsUnique();

            entity.Property(e => e.Pid).ValueGeneratedNever();
            entity.Property(e => e.Pname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PName");
        });

        modelBuilder.Entity<VwEmployeeDeptDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_employee_dept_details");

            entity.Property(e => e.DeptName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Dept_Name");
            entity.Property(e => e.Designation)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.JoinDate).HasColumnName("joinDate");
        });

        modelBuilder.Entity<VwEmployeedetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_employeedetails");

            entity.Property(e => e.Designation)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

public DbSet<HandsOnEFDBFirstCRUD.ViewModel.EmployeeVM> EmployeeVM { get; set; } = default!;
}
