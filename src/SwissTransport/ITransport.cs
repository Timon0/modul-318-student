﻿using System;

namespace SwissTransport
{
    public interface ITransport
    {
        Stations GetStations(string query);
        StationBoardRoot GetStationBoard(string station, string id);
        Connections GetConnections(string fromStation, string toStattion, DateTime date, DateTime time, int isArrivalTime);
        Stations GetStationsNearby(string latitude, string longtitude);
    }
}