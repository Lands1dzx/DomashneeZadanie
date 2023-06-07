using DomashneeZadanie;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomashneeZadanie
{
    [NotMapped]
    class KitchenWorker : Employee
    {
        [Column("WorkTime")]
        public int worktime { get; set; }

        public KitchenWorker() { }
        public KitchenWorker(string Name, DateTime Dateofemployee, int Pay, int WorkTime)
        : base(Name, Dateofemployee, Pay)
        {
            worktime = WorkTime;
        }
        public override int GetPrice()
        {
            return pay * worktime;
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Количество рабочих часов: " + worktime);
        }
    }
}
