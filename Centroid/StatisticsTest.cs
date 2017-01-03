// Copyright AB SCIEX 2017. All rights reserved.

using System;
using NUnit.Framework;

namespace Centroid
{
    [TestFixture]
    public class StatisticsTest
    {
        private readonly Statistics _stats = new Statistics();

        [Test]
        public void FindHighestYValue()
        {
            Assert.That(Math.Round(_stats.FindHighestYValue(), 0), Is.EqualTo(65682));
        }

        [Test]
        public void FindSecondHighestYValue()
        {
            Assert.That(Math.Round(_stats.FindSecondHighestYValue(), 0), Is.EqualTo(64038));
        }

        [Test]
        public void FindLowestXValue()
        {
            Assert.That(Math.Round(_stats.FindLowestXValue(), 0), Is.EqualTo(100));
        }

        [Test]
        public void FindCentroidValue()
        {
            Assert.That(_stats.FindCentroid(), Is.EqualTo(7));
        }
    }
}