using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Семестр_2_Лаба_3_Завдання_2
{
    internal class Fir : Tree
    {
        public Fir() : base() { }
        public Fir(int Id, int Age, bool PresenceOfPests) : base(Id, "Fir", "Conifers", Age, PresenceOfPests) { }
        public Fir(int Id, int Age) : base(Id, "Fir", "Conifers", Age) { }
    }
}
