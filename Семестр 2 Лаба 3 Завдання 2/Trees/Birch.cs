using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Семестр_2_Лаба_3_Завдання_2
{
    internal class Birch : Tree
    {
        public Birch() : base() { }
        public Birch(int Id,int Age, bool PresenceOfPests) : base(Id,"Birch", "Conifers", Age, PresenceOfPests) { }
        public Birch(int Id, int Age) : base(Id, "Birch", "Conifers", Age) { }
    }
}

