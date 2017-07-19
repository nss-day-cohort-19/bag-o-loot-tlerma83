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
        public void HaveToysAddedToIt(string child)
        {
            _bag.AddToy("kite"); 
            Assert.Equal(_bag.Toys[0], "kite");
        }
    }
}
