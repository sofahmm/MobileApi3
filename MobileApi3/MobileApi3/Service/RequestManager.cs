using MobileApi3.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MobileApi3.Service
{
    public class RequestManager
    {
        IRestService restService;
        public RequestManager(IRestService service)
        {
            restService = service;
        }
        public Task<Rootobject> GetWeather(string city)
        {
            return  restService.GetWeather(city);
        }
    }
}
