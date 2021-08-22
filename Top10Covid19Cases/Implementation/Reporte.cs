using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Top10Covid19Cases.Interfaces;

namespace Top10Covid19Cases.Implementation
{
    public class Reporte : IReporte
    {
        public string deaths { get; set ; }
        public int confirmed { get ; set ; }
        public Region region { get  ; set ; }
    }
}