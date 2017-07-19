using System;
using System.Collections.Generic;
using Xunit;

namespace BagOLoot.Tests
{
    public class BagShould
    {
        private readonly BagofLoot _bag;
        public BagShould()
        {
            _bag = new BagofLoot();
        }


        [Fact]
        public void HaveToysAddedToIt()
        {
            string ToyName = "Skateboard";
            int childId = 715;
            int toyId = _bag.AddToyToBag(ToyName, childId);
            List<int> toys = _bag.GetChildsToys(childId);

            Assert.Contains(toyId, toys);
            // _bag.AddToy("kite"); 
            // Assert.Equal(_bag.Toys[0], "kite");
        }

        // [Fact]
        // public void ReturnListOfToys()
        // {
        //     var result = _bag.GetToys();
        //     Assert.IsType<List<string>>(result);
        // }
    }
}
