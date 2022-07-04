using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Семестр_2_Лаба_3_Завдання_2
{
    abstract class Tree
    {
        public int Id { get; set; }
        public string TreeName;
        public string TreeType;
        public int Age;
        public bool PresenceOfPests;
        public Tree() { }
        public Tree(int Id ,string TreeName , string TreeType , int Age, bool PresenceOfPests)
        {
            this.Id = Id;   
            this.TreeName = TreeName;
            this.TreeType = TreeType;
            this.Age = Age;
            this.PresenceOfPests = PresenceOfPests;
        }
        public Tree(int Id,string TreeName,string TreeType,int Age)
        {
            this.Id= Id;
            this.TreeName= TreeName;
            this.TreeType= TreeType;
            this.Age= Age;
            PresenceOfPests = false;
        }
        private string PresentOrAbsent;
        public void GetInfo()
        {
            if (PresenceOfPests)
                PresentOrAbsent = "Present";
            else
                PresentOrAbsent = "Absent";
            Console.WriteLine($"ID: {Id};\tName:{TreeName};\tType:{TreeType};\tAge:{Age};\tPests: {PresentOrAbsent}");
        }
    }
}
