using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Семестр_2_Лаба_3_Завдання_2
{
    internal class Ash : Tree
    {
        public Ash() : base() { }
        public Ash(int Id, int Age, bool PresenceOfPests) : base(Id , "Ash", "Deciduous", Age, PresenceOfPests) { }
        public Ash(int Id, int Age) : base(Id, "Ash", "Deciduous", Age) { }
    }
}
