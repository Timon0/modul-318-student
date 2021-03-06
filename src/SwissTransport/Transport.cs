﻿using System.IO;
using System.Net;
using Newtonsoft.Json;
using System;

namespace SwissTransport
{
    public class Transport : ITransport
    {
        public Stations GetStations(string query)
        {
            try
            {
                var request = CreateWebRequest("http://transport.opendata.ch/v1/locations?query=" + query);
                var response = request.GetResponse();
                var responseStream = response.GetResponseStream();

                if (responseStream != null)
                {
                    var message = new StreamReader(responseStream).ReadToEnd();
                    var stations = JsonConvert.DeserializeObject<Stations>(message);
                    return stations;
                }
            } catch(WebException e)
            {
                //Make something with the variable, otherwise there would be an warning.
                var dummy = e.Message;
                dummy.Length.ToString();
            }
            return null;
            

        }

        public StationBoardRoot GetStationBoard(string station, string id)
        {
            var request = CreateWebRequest("http://transport.opendata.ch/v1/stationboard?Station=" + station + "&id=" + id);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var stationboard =
                    JsonConvert.DeserializeObject<StationBoardRoot>(readToEnd);
                return stationboard;
            }

            return null;
        }

        public Connections GetConnections(string fromStation, string toStattion, DateTime date, DateTime time, int isArrivalTime)
        {
            var request = CreateWebRequest("http://transport.opendata.ch/v1/connections?from=" + fromStation + "&to=" + toStattion + "&date=" + date.ToString("yyyy-MM-dd") + "&time=" + time.ToString("HH:mm") + "&isArrivalTime=" + isArrivalTime);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var connections =
                    JsonConvert.DeserializeObject<Connections>(readToEnd);

                return connections;
            }

            return null;
        }

        public Stations GetStationsNearby(string latitude, string longtitude)
        {
            var request = CreateWebRequest("http://transport.opendata.ch/v1/locations?x=" + latitude + "&y=" + longtitude);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var message = new StreamReader(responseStream).ReadToEnd();
                var stations = JsonConvert.DeserializeObject<Stations>(message);
                return stations;
            }

            return null;

        }

        private static WebRequest CreateWebRequest(string url)
        {
            var request = WebRequest.Create(url);
            var webProxy = WebRequest.DefaultWebProxy;

            webProxy.Credentials = CredentialCache.DefaultNetworkCredentials;
            request.Proxy = webProxy;
            
            return request;
        }
    }
}
