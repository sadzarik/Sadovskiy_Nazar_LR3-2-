using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Семестр_2_Лаба_3_Завдання_2
{
    internal class Poplar : Tree
    {
        public Poplar() : base() { }
        public Poplar(int Id, int Age) : base(Id, "Poplar", "Deciduous", Age) { }
        public Poplar(int Id,int Age, bool PresenceOfPests) : base(Id, "Poplar", "Deciduous", Age, PresenceOfPests) { }
    }
}
