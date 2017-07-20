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
        public void ShouldAddToyToBag()
        {
            string ToyName = "Skateboard";
            int childId = 715;
            bool toyAdded = _bag.AddToyToBag(ToyName, childId);
            Assert.True(toyAdded);
        }

        [Fact]
        public void getListofKidsWithToys ()
        {
            int childId = 4;
            List<Toy> kidList = _bag.AllChildrenWithAToy(childId);

            Assert.IsType<List<Toy>>(kidList);

        }

        [Fact]
         public void ReturnToyListPerChild ()
        {
            int childId = 4;
            var ToyList = _bag.GetToyListPerChild(childId);

            Assert.IsType<List<Toy>>(ToyList);

        }
    }
}
