using api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace api.Controllers
{
    public class WebApiController : ApiController
    {
        User[] users = new User[]
        {
            new User
            {
                ID=1,Name="demo",Date = DateTime.Parse(DateTime.Today.ToString()),age=20 },
        };

        public IEnumerable<User> GetUsers()
        {
            return users;
        }
    }
}
