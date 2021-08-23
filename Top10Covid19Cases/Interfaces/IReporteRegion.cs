using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Top10Covid19Cases.Implementation;

namespace Top10Covid19Cases.Interfaces
{
    interface IReporteRegion : IReporte
    {
        Region region { get; set; }
    }
}
