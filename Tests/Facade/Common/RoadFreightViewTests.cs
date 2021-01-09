using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Facade.Common;

namespace SemestriProject.Tests.Facade.Common
{
    [TestClass]
    public class RoadFreightViewTests : AbstractClassTests<RoadFreightView, DefinedEntityView>
    {

    private class testClass : RoadFreightView { }

    [TestInitialize]
    public override void TestInitialize()
    {
        base.TestInitialize();
        obj = new testClass();
    }

    [TestMethod]
    public void LoadingTest()
    {
        isNullableProperty(() => obj.Loading, x => obj.Loading = x);
    }

    [TestMethod]
    public void DeparturesTest()
    {
        isNullableProperty(() => obj.Departures, x => obj.Departures = x);
    }
    }
}
