using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Семестр_2_Лаба_3_Завдання_2
{
    internal class Forester
    {
        static void Main(string[] args)
        {
            Forest forest = new Forest();
            Oak oak1 = new (1,70);
            forest.AddTree(oak1);
            oak1.GetInfo();
            Pine pine1 = new (2,45, true);
            forest.AddTree(pine1);
            pine1.GetInfo();

            Poplar poplar1 = new (3,50, true);
            Poplar poplar2 = new (4,50, true);
            Oak oak2 = new (5,25);
            Pine pine2 = new(6,40);
            Ash ash1 = new (7,48);
            Ash ash2 = new (8,80,true);
            Oak oak3 =new (9,55);
            Fir fir1 =new (10,20);
            Birch birch1 = new (11, 39);
            Birch birch2 = new (12, 34);
            Birch birch3 = new (13, 35, true);
            Birch birch4 = new (14, 37);
            Birch birch5 = new (15, 43);
            Linden linden1 = new (16,57);
            Linden linden2 = new (17, 57);
            Linden linden3 = new (18, 54);
            Linden linden4 = new (19, 53, true);
            Linden linden5 = new (20, 58);
            Linden linden6 = new (21, 59);
            Linden linden7 = new (22, 41);
            forest.AddTree(ash2);
            forest.AddTree(ash1);
            forest.AddTree(pine2);
            forest.AddTree(poplar1);
            forest.AddTree(linden4);
            forest.AddTree(linden5);
            forest.AddTree(linden6);
            forest.AddTree(linden7);
            forest.AddTree(poplar2);
            forest.AddTree(oak2);
            forest.AddTree(oak3);
            forest.AddTree(fir1);
            forest.AddTree(birch1);
            forest.AddTree(birch2);
            forest.AddTree(birch3);
            forest.AddTree(birch4);
            forest.AddTree(birch5);
            forest.AddTree(linden1);
            forest.AddTree(linden2);
            forest.AddTree(linden3);

            forest.AreaInSquareKilometers(12, 10);
            forest.SortByAge();
            forest.SortByType();
            forest.SortByCount();
            forest.CountOfTrees();
            forest.RemoveTree(birch3);
            forest.CountOfTrees();
            forest.SortByAge();
        }
    }
}
