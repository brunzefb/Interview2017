// Copyright AB SCIEX 2017. All rights reserved.

using NUnit.Framework;

namespace Centroid
{
    /// <summary>
    /// Class DataTest.
    /// </summary>
    [TestFixture]
    public class DataTest
    {
        /// <summary>
        /// Cardinalities this instance.
        /// </summary>
        [Test]
        public void Cardinality()
        {
            Assert.That(Data.XValues.Length, Is.EqualTo(21635));
            Assert.That(Data.YValues.Length, Is.EqualTo(21635));
        }
    }
}