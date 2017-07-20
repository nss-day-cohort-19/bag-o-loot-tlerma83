using System;
using System.Collections.Generic;

namespace BagOLoot
{
    public class Toy
    {
        public string toyName {get;}
        public int toyId {get;}
        public int childId {get;}

        public Toy (string type, int toyID, int childID) 
        {
            toyName = type;
            toyId = toyID;
            childId = childID;
        }
    }
}