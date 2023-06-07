//using Microsoft.Data.Sqlite;
using DomashneeZadanie;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.Collections.Generic;

namespace DomashneeZadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new RaphaelDb())
            {
                context.Database.EnsureCreated();

                var existingEmployees = context.Employees.ToList();
                var mass = new List<Employee>
                {
                    new KitchenWorker("Константин", new DateTime(1989, 05, 26), 65000, 14),
                    new KitchenWorker("Ренат", new DateTime(2023, 01, 19), 24000, 4),
                    new Waiter("Дарья", new DateTime(2022, 03, 01), 27500, 3, 2500),
                    new Waiter("Даниил", new DateTime(2017, 07, 22), 29500, 8, 4500),
                    new Manager("Антон", new DateTime(2004, 01, 11), 51100),
                    new JuniorManager("Оксана", new DateTime(2020, 04, 30), 31412),
                    new Waiter("Петя", new DateTime(2018, 07, 12), 27600, 9, 4800),

                };

                foreach (var employee in mass) 
                {
                    if (existingEmployees.Any(e => e.name == employee.name && e.pay == employee.pay && e.dateofemployee == employee.dateofemployee)) 
                    {
                        continue;
                    }
                    context.Employees.Add(employee);
                }
                context.SaveChanges();

                /*if (!context.Employees.Any(e => e.name == employee.name && e.pay == employee.pay  && e.dateofemployee == employee.dateofemployee))
                {
                   context.Add(employee);
                   context.SaveChanges();

                }
                else
                {
                    continue;
                }*/

                RaphaelDb.dbRead(context);


                }
            }
                      

        }
    }
