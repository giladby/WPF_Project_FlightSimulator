﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulatorApp
{
    class MyStatus
    {
        static public string okStatus = "OK";
        static public string connectedStatus = "Connected";
        static public string notConnectedStatus = "Not Connected";
        static public string tryingToConnectStatus = "Trying To Connect...";
        static public string connectionFailedStatus = "Failed Connecting To Simulator";
        static public string disconnectedStatus = "The Simulator Disconnected";
        static public string rcvErrorStatus = "Error Trying To Receive Data From Simulator";
        static public string sendErrorStatus = "Error Trying To Send Data To Simulator";
        static public string latitudeErrorStatus = "Received Invalid Latitude Value";
        static public string longitudeErrorStatus = "Received Invalid Longitude Value";
        static public string startLatitudeErrorStatus = "Initialized With Invalid Latitude Value";
        static public string startLongitudeErrorStatus = "Initialized With Invalid Longitude Value";
    }
}