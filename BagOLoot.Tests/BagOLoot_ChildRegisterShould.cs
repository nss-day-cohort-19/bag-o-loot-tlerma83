using System;
using System.Collections.Generic;
using Xunit;

namespace BagOLoot.Tests
{
    public class ChildRegisterShould
    {
        private readonly ChildRegister _register;

        public ChildRegisterShould()
        {
            _register = new ChildRegister();
        }

        [Theory]
        [InlineData("Sarah")]
        [InlineData("Jamal")]
        [InlineData("Kelly")]
        public void AddChildren(string child)
        {
            var result = _register.AddChild(child);
            Assert.True(result);
        }

        [Fact]
        public void ReturnListOfChildren()
        {

            List<(string, int)> children = _register.GetChildren();

            // children.Add("Maddy");
            Assert.IsType<List<(string, int)>>(children);

            Assert.True(children.Count > 0);
        }

        [Fact]
        public void ReturnChildObjectWithIdAndName () 
        {
            int childId = 4;
            Object childObject = _register.GetChild(childId);
            childObject = childId;
            Assert.IsType<Object>(childObject);
            // Assert.IsType<List<(string, int)>>(children);
        }
    }
}
