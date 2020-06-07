using Microsoft.EntityFrameworkCore;
using AspEFCore.Domain;
using System.Collections.Generic;
using AspEFCore.Model;

namespace AspEFCore.Data
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }

        //将多对多的关系映射到数据库里
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            //设置中间表的主码
            modelBuilder.Entity<OrderProduct>().
                HasKey(x => new { x.OrderId,x.ProductId });
            modelBuilder.Entity<OrderUser>().
                HasKey(x => new { x.OrderId, x.UserId });
            modelBuilder.Entity<ProductCClass>().
                HasKey(x => new { x.ProductId, x.CClassId });

            //设置其他对应关系
            modelBuilder.Entity<Order>()
                 .HasOne(x => x.Prodeuct).WithMany(x => x.Orders).HasForeignKey(x => x.ProductId);
            modelBuilder.Entity<Order>()
                 .HasOne(x => x.User).WithMany(x => x.Orders).HasForeignKey(x => x.UserId);
            modelBuilder.Entity<Product>()
                 .HasOne(x => x.CClass).WithMany(x => x.Products).HasForeignKey(x => x.CClassId);

            /*
            //设置中间表的主码为x.CityId, x.CompanyId
            modelBuilder.Entity<CityCompany>().
                HasKey(x => new { x.CityId, x.CompanyId });

            //设置另一对应关系
            modelBuilder.Entity<CityCompany>()
                .HasOne(x => x.City).WithMany(x => x.CityCompanies).HasForeignKey(x => x.CityId);

            //设置另一对应关系
            modelBuilder.Entity<CityCompany>()
                .HasOne(x => x.Company).WithMany(x => x.CityCompanies).HasForeignKey(x => x.CompanyId);

            modelBuilder.Entity<Mayor>()
                .HasOne(x => x.City).WithOne(x => x.Mayor).HasForeignKey<Mayor>(x => x.CityId);

            modelBuilder.Entity<City>()
                 .HasOne(x => x.Province).WithMany(x => x.Cities).HasForeignKey(x => x.ProvinceId);

            //添加种子数据就是初始化数据

            modelBuilder.Entity<AspEFCore1>()
                .HasData(
                new AspEFCore1
                {
                    Id =1,
                    Name="ddd广东",
                    Population =9_000_000
                },
                new AspEFCore1
                { 
                    Id = 2,
                    Name = "dddfff广东",
                    Population = 9_000_000,
                }
                );

            modelBuilder.Entity<City>().HasData(
                
                        //添加关联属性
                        new { ProvinceId=6,Id=61,Name="nanjing"},
                        new { ProvinceId = 6, Id=61,Name="nanjing"},
                        new { ProvinceId = 6, Id=61,Name="nanjing"}
  
                );
        */

        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<CClass> CClasss { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }


        /* public DbSet<Province> Provinces { get; set; }
         public DbSet<City> Cities { get; set; }
         public DbSet<CityCompany> CityCompanies { get; set; }
         public DbSet<Company> Companies { get; set; }
         public DbSet<Mayor> Mayors { get; set; }
         public DbSet<AspEFCore1> AspEFCore1 { get; set; }
        */

        /*//数据库连接字符
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=AspEFCoreDemo1; Trusted_Connection=True;");
        }*/
    }
}

