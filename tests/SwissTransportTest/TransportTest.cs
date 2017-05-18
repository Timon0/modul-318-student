using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SwissTransport
{
    [TestClass]
    public class TransportTest
    {
        private ITransport testee;

        [TestMethod]
        public void Locations()
        {
            testee = new Transport();
            var stations = testee.GetStations("Sursee,");

            Assert.AreEqual(50, stations.StationList.Count);
        }

        [TestMethod]
        public void StationBoard()
        {
            testee = new Transport();
            var stationBoard = testee.GetStationBoard("Sursee", "8502007");

            Assert.IsNotNull(stationBoard);
        }

        [TestMethod]
        public void Connections()
        {
            testee = new Transport();
            var connections = testee.GetConnections("Sursee", "Luzern", DateTime.Now, DateTime.Now);

            Assert.IsNotNull(connections);
        }

        [TestMethod]
        public void StationsNearby()
        {
            testee = new Transport();
            var stations = testee.GetStationsNearby("47.0800087", "8.3295627");

            Assert.IsNotNull(stations);
        }
    }
}
