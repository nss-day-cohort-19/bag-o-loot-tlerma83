using System;
using System.Collections.Generic;
using Xunit;

namespace BagOLoot.Tests
{
    public class RemoveToyFromChildShould
    {
        private readonly RemoveLoot _removeItem;
        public RemoveToyFromChildShould()
        {
            _removeItem = new RemoveLoot();
        }


        public void RemoveToyFromChildsBag()
        {
            int childId = 5;
            int toyId = 4;
            List<int> toysList = _removeItem.GetListofChildsToys(childId);
            List<int> alteredToyList = _removeItem.RemoveToyFromChild(childId, toyId);

            Assert.DoesNotContain(toyId, alteredToyList);
        }
    }
}
