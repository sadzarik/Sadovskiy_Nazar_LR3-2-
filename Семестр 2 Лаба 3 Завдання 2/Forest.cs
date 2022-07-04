using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Семестр_2_Лаба_3_Завдання_2
{
    internal class Forest
    {
        public void AreaInSquareKilometers(double lengthOfForestInKilometers,double widthOfForestInKilometers)
        {
            double square = lengthOfForestInKilometers * widthOfForestInKilometers;
            Console.WriteLine($"Size of this forest is {square} square kilometers");
        }
        public void CountOfTrees()
        {
            int count = trees.Count;
            Console.WriteLine("Count of trees:\t"+ count);
        }
        List<Tree> trees;
        public Forest()
        {
            trees = new List<Tree>();
        }
        public void AddTree(Tree tree)
        {
            trees.Add(tree);
        }
        public void RemoveTree(Tree tree)
        {
            trees.Remove(tree);
            Console.WriteLine($"Old tree (Id: {tree.Id},Name: {tree.TreeName}) was cut down:(");
        }
        public void PlantNewTree(Tree tree)
        {
            trees.Add(tree);
            Console.WriteLine($"New tree (Id: {tree.Id},Name: {tree.TreeName}) was planted:)");
        }
        public void SortByAge()
        {
            Console.WriteLine("SORT BY AGE");
            var result = trees.OrderBy(t => t.Age);
            foreach (var item in result)
            {
                item.GetInfo();
            }
            Console.WriteLine();
        }
        public void SortByType()
        {
            Console.WriteLine("SORT BY TYPE");
            var result = trees.OrderBy(t => t.TreeType);
            foreach (var item in result)
            {
                item.GetInfo();
            }
            Console.WriteLine();
        }
        public void SortByCount()
        {
            Console.WriteLine("SORT BY COUNT");
            var result = trees.GroupBy(t => t.TreeName).OrderByDescending(t=>t.Count()).ToList();
            foreach (var item in result)
            {
                foreach (var item2 in item)
                {
                    item2.GetInfo();
                }
            }
            Console.WriteLine();
        }
    }
}
