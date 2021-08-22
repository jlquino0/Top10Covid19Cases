using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Top10Covid19Cases.Implementation;
using Top10Covid19Cases.Interfaces;

namespace Top10Covid19Cases.Utils
{
    public class RequestHandler : 
        IRequestHandler<IRegion>,
        IRequestHandlerIReporte<IReporte>,
        IRequestHandlerIReporte<IReporte>

    {

        IEndPointHandler _IEndPointHandler;
        public RequestHandler(IEndPointHandler IEndPointHandler)
        {
            _IEndPointHandler = IEndPointHandler;
        }

        public async Task<List<SelectListItem>> Handle(Region Region)
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri(_IEndPointHandler.uri + "/regions"),
                    Headers =
                {
                    { "x-rapidapi-host", _IEndPointHandler.x_rapidapi_host },
                    { "x-rapidapi-key", _IEndPointHandler.x_rapidapi_key },
                },
                };
                using (var response = await client.SendAsync(request))
                {
                    var responseData = response.Content.ReadAsStringAsync().Result;
                    JObject result = JObject.Parse(responseData);

                    var clientarray = result["data"].Value<JArray>();
                    List<Region> clients = clientarray.ToObject<List<Region>>();

                    List<SelectListItem> listS = new List<SelectListItem>();

                    foreach (Region row in clients)
                    {
                        listS.Add(new SelectListItem()
                        {
                            Value = row.iso,
                            Text = row.name

                        });
                    }

                    return listS;

                }
                
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Reporte>> Handle(Reporte reporte)
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://covid-19-statistics.p.rapidapi.com/reports"),
                    Headers =
                {
                    { "x-rapidapi-host", _IEndPointHandler.x_rapidapi_host },
                    { "x-rapidapi-key", _IEndPointHandler.x_rapidapi_key },
                },
                };
                using (var response = await client.SendAsync(request))
                {
                    var responseData = response.Content.ReadAsStringAsync().Result;
                    JObject result = JObject.Parse(responseData);

                    var report = result["data"].Value<JArray>();
                    List<Reporte> clients = report.ToObject<List<Reporte>>();

                    var newList = clients.OrderByDescending(x => x.confirmed).ToList().Take(10).Cast<Reporte>().ToList();

                    return newList;

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}