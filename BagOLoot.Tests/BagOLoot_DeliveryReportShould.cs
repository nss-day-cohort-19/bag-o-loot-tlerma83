using System;
using System.Collections.Generic;
using Xunit;

namespace BagOLoot.Tests
{
    public class DeliveryReportShould 
    {
        private DeliveryReport _report;

        public DeliveryReportShould ()
        {
            _report = new DeliveryReport();
        }

        [Fact]
        public void ListOfToysDelivered()
        {
            int toyId = 4;
            bool result = _report.toyDelivered(toyId);
            Assert.True(result);
        }

    }
}