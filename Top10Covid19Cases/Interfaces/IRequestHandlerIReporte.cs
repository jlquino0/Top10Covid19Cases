using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Top10Covid19Cases.Implementation;

namespace Top10Covid19Cases.Interfaces
{
    interface IRequestHandlerIReporte<IReporte>
    {
        System.Threading.Tasks.Task<List<Reporte>> Handle(Reporte reporte);
    }
}
