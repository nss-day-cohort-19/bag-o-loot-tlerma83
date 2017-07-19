using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Sqlite;

namespace BagOLoot
{
    public class BagofLoot
    {
        // public List<string> Toys {get; set;}= new List<string>();

        // public void AddToy(string toy) 
        // {
        //     Toys.Add(toy);
        // }

        public int AddToyToBag(string toy, int childId)
        {
            return 4;
        }

        public List<int> GetChildsToys(int childId)
        {
            return new List<int>(){6, 7, 4};
        }

        // public string GetToys()
        // {
        //     return Toys[0];
        // }
    }
}