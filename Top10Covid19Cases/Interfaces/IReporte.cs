using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Top10Covid19Cases.Implementation;

namespace Top10Covid19Cases.Interfaces
{
    public interface IReporte
    {
        string deaths { get; set; }
        int confirmed { get; set; }
        //Region region { get; set; }
    }
}
