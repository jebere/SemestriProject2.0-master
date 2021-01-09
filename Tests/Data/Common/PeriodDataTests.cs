using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Data.Common;
using SemestriProject.Tests;

namespace Tests.Data.Common
{
    [TestClass]
    public class PeriodDataTests : AbstractClassTests<PeriodData, object>
    {
        private class testClass : PeriodData { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new testClass();
        }
        [TestMethod]
        public void OrderTimeTest()
        {
            isNullableProperty(() => obj.OrderTime, x => obj.OrderTime = x);
        }
    }
}
