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

            List<Child> children = _register.GetChildren();

            Assert.IsType<List<Child>>(children);

            Assert.True(children.Count > 0);

            int childId = 4;
            Child child = _register.GetChild(childId);
            Assert.True(child.childId == childId);

        }
    }
}
