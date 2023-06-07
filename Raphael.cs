using DomashneeZadanie;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DomashneeZadanie
{
    class RaphaelDb : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Data Source=RaphaelDb.db";
            optionsBuilder.UseSqlite(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Employee>()
            .HasDiscriminator<string>("Type");
            builder.Entity<Manager>();
            builder.Entity<JuniorManager>();
            builder.Entity<KitchenWorker>();
            builder.Entity<Waiter>();

            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        public static void dbRead(RaphaelDb context)
        {
            foreach (var employee in context.Employees)
            {
                if (employee is JuniorManager)
                {
                    Console.WriteLine($"Id: {employee.Id}, Name: {employee.name}, Pay {employee.pay}, DateEmployee {employee.dateofemployee} Type: JuniorManager");
                }
                else if (employee is Manager)
                {
                    Console.WriteLine($"Id: {employee.Id}, Name: {employee.name},Pay {employee.pay}, DateEmployee {employee.dateofemployee} Type: Manager");
                }
                else if (employee is KitchenWorker)
                {
                    Console.WriteLine($"Id: {employee.Id}, Name: {employee.name},Pay {employee.pay}, DateEmployee {employee.dateofemployee} Type: KitchenWorker");
                }
                else if (employee is Waiter)
                {
                    Console.WriteLine($"Id: {employee.Id}, Name: {employee.name},Pay {employee.pay}, DateEmployee {employee.dateofemployee} Type: Waiter");
                }
            }
        }
    }
}
