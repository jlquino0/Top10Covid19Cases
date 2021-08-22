using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using Top10Covid19Cases.Interfaces;

namespace Top10Covid19Cases.Utils
{
    public class EndPointsHandler : IEndPointHandler
    {
        public string uri { get; set; }
        public string x_rapidapi_host { get; set; }
        public string x_rapidapi_key { get; set; }

        //EndPointsHandler instance = new EndPointsHandler();
        public EndPointsHandler()
        {
            uri = ConfigurationManager.ConnectionStrings["uri"].ConnectionString;
            x_rapidapi_host = ConfigurationManager.ConnectionStrings["x-rapidapi-host"].ConnectionString;
            x_rapidapi_key = ConfigurationManager.ConnectionStrings["x-rapidapi-key"].ConnectionString;
        }

    }
}