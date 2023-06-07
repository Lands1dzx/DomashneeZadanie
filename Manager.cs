using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomashneeZadanie
{
    [NotMapped]
    class Manager : Employee
    {
        public const int bonus = 200;
        public override int GetPrice()
        {
            return pay + bonus * (DateTime.Now.Year - dateofemployee.Year);
        }
        public Manager(string Name, DateTime Dateofemployee, int Pay)
        : base(Name, Dateofemployee, Pay) { }
        public Manager() { }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Значение рабочих бонусов: " + bonus);
        }
    }
}