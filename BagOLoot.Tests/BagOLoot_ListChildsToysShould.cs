// using System;
// using System.Collections.Generic;
// using Xunit;

// namespace BagOLoot.Tests
// {
//     public class ListChildsToyShould
//     {
//         public string toyNames;
//         public int toyId;
//         public int childId;
//         private Toy _childToys;

//         public ListChildsToyShould()
//         {
//             _childToys = new Toy();
//         }

//         //toys will be sent childID
//         //toys will list all toyNames and ToyIds where childId match in toys
//         //toys will return a list of type Toys 
//         public void ReturnToyListPerChild ()
//         {
//             int childId = 4;
//             List<Toys> ToyList = _childToys.GetToyListPerChild(childId);

//             Assert.Contains(childId, ToyList);

//         }
//     }
// }
