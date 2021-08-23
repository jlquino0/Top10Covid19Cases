using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Top10Covid19Cases.Interfaces;

namespace Top10Covid19Cases.Models
{
    public class Province : IProvince
    {
        public string province { get ; set ; }
        public string iso { get ; set ; }
        public string name { get ; set ; }
    }
}