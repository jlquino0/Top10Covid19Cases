using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Top10Covid19Cases.Interfaces
{
    public interface IProvince : IRegion
    {
        string province { get; set; }
    }
}
