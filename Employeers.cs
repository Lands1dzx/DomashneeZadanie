using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomashneeZadanie
{
    [Table("Employees")]
    abstract class Employee
    {
        [Key] // Добавляем атрибут [Key] к свойству Id (индитефикатор)
        public int Id { get; set; }

        [Column("EmployeeName")]
        public string name { get; set; }

        [Column("EmployeeDate")]
        public DateTime dateofemployee { get; set; }

        [Column("PayAmount")]
        public int pay { get; set; }

        public virtual void GetInfo()
        {
            Console.WriteLine("Имя: " + name + "\nДата трудоустройтсва: " + dateofemployee + "\nСтавка " + pay);
        }
        public virtual int GetPrice() { return 0; }
        public Employee() { }
        public Employee(string Name, DateTime Dateofemployee, int Pay)
        {
            name = Name;
            dateofemployee = Dateofemployee;
            pay = Pay;
        }
    }
}
