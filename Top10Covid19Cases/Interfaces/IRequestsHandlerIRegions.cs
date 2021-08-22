using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Top10Covid19Cases.Implementation;

namespace Top10Covid19Cases.Interfaces
{
    public interface IRequestHandler<IRegion>
    {
        System.Threading.Tasks.Task<List<SelectListItem>> Handle(Region Region);
    }
}
