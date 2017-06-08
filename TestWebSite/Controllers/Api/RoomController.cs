using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TestWebSite.Controllers
{
    [CamelCasedController]
    public class RoomController : ApiController
    {
        //[CamelCasedMethod]
        public HttpResponseMessage Post([FromBody]RoomList roomList)
        {
            return Request.CreateResponse(System.Net.HttpStatusCode.Accepted,
                roomList);
        }

        //public RoomList Post([FromBody]RoomList roomList)
        //{
        //    return roomList;
        //}
    }
}