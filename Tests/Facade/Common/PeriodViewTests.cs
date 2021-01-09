using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Facade.Common;

namespace SemestriProject.Tests.Facade.Common
{
    [TestClass]
    public class PeriodViewTests : AbstractClassTests<PeriodView, object>

    {
    private class testClass : PeriodView
    {
    }

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
