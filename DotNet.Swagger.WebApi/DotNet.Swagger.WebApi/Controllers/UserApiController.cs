using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DotNet.Swagger.WebApi.Controllers
{
    /// <summary>
    /// 用户API
    /// </summary>
   
    public class UserApiController : ApiController
    {
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <returns>获取用户</returns>
        [HttpGet]
        public String GetUser()
        {
            return "";
        }
    }
}
