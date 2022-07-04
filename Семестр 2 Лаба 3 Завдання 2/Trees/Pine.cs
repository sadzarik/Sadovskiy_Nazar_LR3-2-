using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Семестр_2_Лаба_3_Завдання_2
{
    internal class Pine : Tree
    {
        public Pine() : base() { }
        public Pine(int Id, int Age, bool PresenceOfPests) : base(Id,"Pine", "Conifers", Age, PresenceOfPests) { }
        public Pine(int Id, int Age) : base(Id, "Pine", "Conifers", Age) { }
    }
}
