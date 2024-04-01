using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FPTWash.Models;

public partial class LaudryContext : DbContext
{
    public LaudryContext()
    {
    }

    public LaudryContext(DbContextOptions<LaudryContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Feedback> Feedbacks { get; set; }

    public virtual DbSet<News> News { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<Package> Packages { get; set; }

    public virtual DbSet<PackagesOrder> PackagesOrders { get; set; }

    public virtual DbSet<Store> Stores { get; set; }

    public virtual DbSet<SudNews> SudNews { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer(" Data Source=LAPTOP-874PIBRV\\SQLEXPRESS;Initial Catalog=Laudry;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Customer__3213E83FE11C9F49");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.IsAdmin).HasColumnName("is_admin");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Phone)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("phone");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3213E83F09606992");

            entity.ToTable("Employee");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Phone)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.Rank)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("rank");
            entity.Property(e => e.StoreId).HasColumnName("store_id");

            entity.HasOne(d => d.Store).WithMany(p => p.Employees)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("FK__Employee__store___300424B4");
        });

        modelBuilder.Entity<Feedback>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Feedback__3213E83F3B8FD489");

            entity.ToTable("Feedback");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Message)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("message");
            entity.Property(e => e.OrderId).HasColumnName("order_id");

            entity.HasOne(d => d.Order).WithMany(p => p.Feedbacks)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK__Feedback__order___3E52440B");
        });

        modelBuilder.Entity<News>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__News__3213E83F579D4FE1");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Imgae)
                .HasMaxLength(225)
                .IsUnicode(false)
                .HasColumnName("imgae");
            entity.Property(e => e.Title)
                .HasMaxLength(225)
                .IsUnicode(false)
                .HasColumnName("title");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Orders__3213E83F0DA114CE");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.OrderDate)
                .HasColumnType("datetime")
                .HasColumnName("order_date");
            entity.Property(e => e.PickupDate)
                .HasColumnType("datetime")
                .HasColumnName("pickup_date");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("price");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.StoreId).HasColumnName("store_id");
            entity.Property(e => e.Weight)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("weight");
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Order_it__3213E83FEE5D2541");

            entity.ToTable("Order_items");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("price");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("type");
            entity.Property(e => e.Weight)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("weight");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK__Order_ite__order__2A4B4B5E");
        });

        modelBuilder.Entity<Package>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Packages__3213E83FB33083D0");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("price");
        });

        modelBuilder.Entity<PackagesOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Packages__3213E83F498784BE");

            entity.ToTable("Packages_Orders");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.PackageId).HasColumnName("package_id");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("price");

            entity.HasOne(d => d.Customer).WithMany(p => p.PackagesOrders)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__Packages___custo__36B12243");

            entity.HasOne(d => d.Package).WithMany(p => p.PackagesOrders)
                .HasForeignKey(d => d.PackageId)
                .HasConstraintName("FK__Packages___packa__35BCFE0A");
        });

        modelBuilder.Entity<Store>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Stores__3213E83F96350539");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<SudNews>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Sud_News__3213E83F7E7E49E8");

            entity.ToTable("Sud_News");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NewId).HasColumnName("new_id");
            entity.Property(e => e.SubConnect)
                .HasMaxLength(225)
                .IsUnicode(false)
                .HasColumnName("sub_connect");
            entity.Property(e => e.SubContent)
                .HasMaxLength(225)
                .IsUnicode(false)
                .HasColumnName("sub_content");
            entity.Property(e => e.SubImage)
                .HasMaxLength(225)
                .IsUnicode(false)
                .HasColumnName("sub_image");
            entity.Property(e => e.SubTitle)
                .HasMaxLength(225)
                .IsUnicode(false)
                .HasColumnName("sub_title");

            entity.HasOne(d => d.New).WithMany(p => p.SudNews)
                .HasForeignKey(d => d.NewId)
                .HasConstraintName("FK__Sud_News__new_id__3B75D760");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
