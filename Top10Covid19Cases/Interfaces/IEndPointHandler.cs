using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Top10Covid19Cases.Utils;

namespace Top10Covid19Cases.Interfaces
{
    public interface IEndPointHandler
    {
        string uri { get; set; }
        string x_rapidapi_host { get; set; }
        string x_rapidapi_key { get; set; }

    }
}
