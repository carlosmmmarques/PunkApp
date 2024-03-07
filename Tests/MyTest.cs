using NUnit.Framework;
using PunkApp.Extensions;

namespace Tests
{
    [TestFixture]
    public class MyTest
    {
        [Test]
        public void PhConverter()
		{
			double? value1 = 0;
            double? value2 = null;
            double? value3 = 14;
            double? value4 = 500;
            double? value5 = -1;

            Assert.AreEqual(value1.ConvertFromPh(), 1);
            Assert.AreEqual(value2.ConvertFromPh(), 0);
            Assert.AreEqual(value3.ConvertFromPh(), 0);
            Assert.AreEqual(value4.ConvertFromPh(), 0);
            Assert.AreEqual(value5.ConvertFromPh(), 1);
        }

        [Test]
        public void AbvConverter()
        {
            double? value1 = 0;
            double? value2 = null;
            double? value3 = 10;
            double? value4 = 500;
            double? value5 = -1;

            Assert.AreEqual(value1.ConvertFromAbv(), 0);
            Assert.AreEqual(value2.ConvertFromAbv(), 0);
            Assert.AreEqual(value3.ConvertFromAbv(), 1);
            Assert.AreEqual(value4.ConvertFromAbv(), 1);
            Assert.AreEqual(value5.ConvertFromAbv(), 0);
        }

        [Test]
        public void SrmConverter()
        {
            double? value1 = 0;
            double? value2 = null;
            double? value3 = 40;
            double? value4 = 500;
            double? value5 = -1;

            Assert.AreEqual(value1.ConvertFromSrm(), 0);
            Assert.AreEqual(value2.ConvertFromSrm(), 0);
            Assert.AreEqual(value3.ConvertFromSrm(), 1);
            Assert.AreEqual(value4.ConvertFromAbv(), 1);
            Assert.AreEqual(value5.ConvertFromSrm(), 0);
        }

        [Test]
        public void IbuConverter()
        {
            double? value1 = 0;
            double? value2 = null;
            double? value3 = 100;
            double? value4 = 500;
            double? value5 = -1;

            Assert.AreEqual(value1.ConvertFromIbu(), 0);
            Assert.AreEqual(value2.ConvertFromIbu(), 0);
            Assert.AreEqual(value3.ConvertFromIbu(), 1);
            Assert.AreEqual(value4.ConvertFromIbu(), 1);
            Assert.AreEqual(value5.ConvertFromIbu(), 0);
        }
    }
}
