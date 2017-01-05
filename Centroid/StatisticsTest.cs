// Copyright AB SCIEX 2017. All rights reserved.

using System;
using NUnit.Framework;

namespace Centroid
{
    /// <summary>
    /// Class StatisticsTest.
    /// </summary>
    [TestFixture]
    public class StatisticsTest
    {
        /// <summary>
        /// The stats
        /// </summary>
        private readonly Statistics _stats = new Statistics();

        /// <summary>
        /// Finds the highest y value.
        /// </summary>
        [Test]
        public void FindHighestYValue()
        {
            Assert.That(Math.Round(_stats.FindHighestYValue(), 0), Is.EqualTo(65682));
        }

        /// <summary>
        /// Finds the second highest y value.
        /// </summary>
        [Test]
        public void FindSecondHighestYValue()
        {
            Assert.That(Math.Round(_stats.FindSecondHighestYValue(), 0), Is.EqualTo(64038));
        }

        /// <summary>
        /// Finds the lowest x value.
        /// </summary>
        [Test]
        public void FindLowestXValue()
        {
            Assert.That(Math.Round(_stats.FindLowestXValue(), 0), Is.EqualTo(100));
        }

        /// <summary>
        /// Finds the centroid value.
        /// </summary>
        [Test]
        public void FindCentroidValue()
        {
            Assert.That(_stats.FindCentroid(), Is.EqualTo(7));
        }
        /// <summary>
        /// Whens the y data is null then return zero.
        /// </summary>
        [Test]
        public void WhenYDataIsNull_ThenReturnZero()
        {
            Data.YValues = null;
            Assert.That(Math.Round(_stats.FindHighestYValue(), 0), Is.EqualTo(0));
        }
        /// <summary>
        /// Whens the x data is null then return zero.
        /// </summary>
        [Test]
        public void WhenXDataIsNull_ThenReturnZero()
        {
            Data.XValues = null;
            Assert.That(Math.Round(_stats.FindLowestXValue(), 0), Is.EqualTo(0));
        }
        /// <summary>
        /// Whens the centroid data is null then return zero.
        /// </summary>
        [Test]
        public void WhenCentroidDataIsNull_ThenReturnZero()
        {
            Data.CentroidY = null;
            Assert.That(Math.Round(_stats.FindCentroid(), 0), Is.EqualTo(0));
        }
    }
}