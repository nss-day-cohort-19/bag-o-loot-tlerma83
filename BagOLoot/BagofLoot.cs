using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Sqlite;

namespace BagOLoot
{
    public class BagofLoot
    {
        public List<(string, int)> Toys {get; set;}= new List<(string, int)>();

        // public void AddToy(string toy) 
        // {
        //     Toys.Add(toy);
        // }

        public int AddToyToBag(string toy, int childId)
        {
            Toys.Add((toy, childId));
            return 4;
        }

        public List<int> GetChildsToys(int childId)
        {
            return new List<int>(){6, 7, 4};
        }

        public List<int> AllChildrenWithAToy(int childId)
        {
            return new List<int>() {4, 5, 6, 7};
        }

        // public int RemoveToyFromBag (int childId, int toyId) {
        //     return 4;
        // }

        // public string GetToys()
        // {
        //     return Toys[0];
        // }
    }
}