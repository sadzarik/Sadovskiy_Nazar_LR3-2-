using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Семестр_2_Лаба_3_Завдання_2
{
    internal class Linden : Tree 
    {
        public Linden() : base() { }
        public Linden(int Id, int Age, bool PresenceOfPests) : base (Id, "Linden", "Deciduous", Age, PresenceOfPests) { }
        public Linden(int Id, int Age) : base(Id, "Linden", "Deciduous", Age) { }
    }
}
