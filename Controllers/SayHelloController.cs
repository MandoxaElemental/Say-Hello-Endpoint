// dotnet new webapi & dotnet watch run <- Important; Copy for every project for now on

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Say_Hello_Endpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHelloController : ControllerBase
    {
         public List<string> nameList = new();
        [HttpPost]
        [Route("AddName/{nameToAdd}")]
        public List<string> AddNameToList(string nameToAdd){
            nameList.Add("Hello, " + nameToAdd + "! It is nice to meet you!");
            return nameList;
        }
    }
}