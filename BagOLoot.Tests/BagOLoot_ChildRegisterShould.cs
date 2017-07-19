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

            List<int> children = _register.GetChildren();

            children.Add(5);
            Assert.IsType<List<string>>(children);

            Assert.True(children.Count > 0);
        }
    }
}
