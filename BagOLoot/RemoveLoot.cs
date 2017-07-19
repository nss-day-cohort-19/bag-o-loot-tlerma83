using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Sqlite;

namespace BagOLoot
{
    public class RemoveLoot
    {
        public List<string> ListOfChildren()
        {
            return new List<string>();
        }
        public List<(string, int)> Toys {get; set;}= new List<(string, int)>();

        public List<int> GetListofChildsToys(int childId)
        {
            return new List<int>() {4, 5, 6, 7};
        }

        public List<int> GetChildsToys(int childId)
        {
            return new List<int>(){6, 7, 4};
        }

        public List<int> RemoveToyFromChild(int childId, int toyId)
        {
            return new List<int>(){6, 7};
        }
    }
}