// Copyright AB SCIEX 2017. All rights reserved.

using NUnit.Framework;

namespace Centroid
{
    [TestFixture]
    public class DataTest
    {
        [Test]
        public void Cardinality()
        {
            Assert.That(Data.XValues.Length, Is.EqualTo(21635));
            Assert.That(Data.YValues.Length, Is.EqualTo(21635));
        }
    }
}