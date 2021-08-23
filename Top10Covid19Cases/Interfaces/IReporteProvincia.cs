using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Top10Covid19Cases.Models;

namespace Top10Covid19Cases.Interfaces
{
    public interface IReporteProvincia : IReporte
    {
        Province province { get; set; }
    }
}
