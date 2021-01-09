using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Facade.Common;

namespace SemestriProject.Tests.Facade.Common
{
    [TestClass]
    public class SeaFreightViewTests : AbstractClassTests<SeaFreightView, DefinedEntityView>

    {
        private class testClass : SeaFreightView { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new testClass();
        }

        [TestMethod]
        public void LiftingCapacityTest()
        {
            isNullableProperty(() => obj.LiftingCapacity, x => obj.LiftingCapacity = x);
        }

        [TestMethod]
        public void ContainerTypeTest()
        {
            isNullableProperty(() => obj.ContainerType, x => obj.ContainerType = x);
        }
    }
}
