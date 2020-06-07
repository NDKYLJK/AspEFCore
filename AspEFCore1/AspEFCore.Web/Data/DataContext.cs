using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspEFCore.Model;
using Microsoft.EntityFrameworkCore;

namespace AspEFCore.Web.Data
{
    public class DataContext: DbContext
    {
        //链接相应的数据库
        public DataContext(DbContextOptions<DataContext> options) 
            :base(options)
        { 

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<CClass> CClasss { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
    
}
