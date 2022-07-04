using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Семестр_2_Лаба_3_Завдання_2
{
    internal class Oak : Tree
    {
        public Oak() : base() { }
        public Oak(int Id, int Age, bool PresenceOfPests) : base (Id, "Oak", "Deciduous", Age,PresenceOfPests) { }
        public Oak(int Id, int Age) : base(Id, "Oak", "Deciduous", Age) { }
    }
}
