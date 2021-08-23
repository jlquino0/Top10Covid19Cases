using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Top10Covid19Cases.Models;

namespace Top10Covid19Cases.Interfaces
{
    interface IRequestHandlerProvincia<ReporteProvince>
    {
        System.Threading.Tasks.Task<List<ReporteProvince>> Handle(Province reporte);
    }
}
