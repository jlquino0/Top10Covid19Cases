using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Top10Covid19Cases.Interfaces;

namespace Top10Covid19Cases.Models
{
    public class ReporteProvince : IReporteProvincia
    {
        public Province province { get ; set ; }
        public string deaths { get ; set ; }
        public int confirmed { get ; set ; }
    }
}