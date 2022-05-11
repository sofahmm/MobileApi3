using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MobileApi3.Model;

namespace MobileApi3.Service
{
    public interface IRestService
    {
        Task<Rootobject> GetWeather(string city);
    }
}
