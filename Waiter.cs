using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomashneeZadanie
{
    [NotMapped]
    class Waiter : Employee
    {
        [Column("WorkTime")]
        public int worktime { get; set; }

        [Column("Tip")]
        public int tip { get; set; }
        public override int GetPrice()
        {
            return pay * worktime + tip;
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Количество рабочих часов: " + worktime + "\nЧаевые: " + tip);
        }
        public Waiter() { }
        public Waiter(string Name, DateTime Dateofemployee, int Pay, int WorkTime, int Tip)
        : base(Name, Dateofemployee, Pay)
        {
            worktime = WorkTime;
            tip = Tip;
        }
    }
}