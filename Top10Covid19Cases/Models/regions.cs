using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Top10Covid19Cases.Interfaces;

namespace Top10Covid19Cases.Models
{
    public class Region : IRegion
    {
        public string iso { get; set; }
        public string name { get; set; }

    }
}