﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SemestriProject.Tests.Infra
{
    [TestClass]
    public class IsInfraTested : AssemblyTests
    {
        private const string assembly = "SemestriProject.Infra";

        protected override string Namespace(string name)
        {
            return $"{assembly}.{name}";
        }

        [TestMethod]
        public void IsCommonTested()
        {
            isAllTested(assembly, Namespace("Common"));
        }
        [TestMethod]
        public void IsOrderTested()
        {
            isAllTested(assembly, Namespace("Order"));
        }
        [TestMethod]
        public void IsAirFreightTested()
        {
            isAllTested(assembly, Namespace("AirFreight"));
        }

        [TestMethod]
        public void IsRoadFreightTested()
        {
            isAllTested(assembly, Namespace("RoadFreight"));
        }

        [TestMethod]
        public void IsSeaFreightTested()
        {
            isAllTested(assembly, Namespace("SeaFreight"));
        }

        [TestMethod]
        public void IsTested()
        {
            isAllTested(assembly, base.Namespace("Infra"));
        }
    }
}
