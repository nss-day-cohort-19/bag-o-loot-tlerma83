using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Sqlite;

namespace BagOLoot
{
    public class BagofLoot
    {
        public List<string> Toys {get; set;}= new List<string>();

        public void AddToy(string toy) 
        {
            Toys.Add(toy);
        }
    }
}