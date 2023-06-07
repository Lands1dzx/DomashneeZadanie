using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using DomashneeZadanie;

namespace DomashneeZadanie
{
    [NotMapped]
    class JuniorManager : Manager
    {
        public override int GetPrice()
        {
            if (DateTime.Now.Month == 12 || DateTime.Now.Month == 6)
                return pay + bonus * (DateTime.Now.Year - dateofemployee.Year);
            else
                return pay;
        }
        public JuniorManager(string Name, DateTime Dateofemployee, int Pay)
        : base(Name, Dateofemployee, Pay) { }
        public JuniorManager() { }
    }
}
