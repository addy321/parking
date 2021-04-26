using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp2.Controllers
{
    public class BaseController: Controller
    {

        protected void SetSession(string value)
        {
            //设置session
            HttpContext.Session.SetString("loginUser", value);
        }
        protected string GetSession()
        {
            //获取session
            var value = HttpContext.Session.GetString("loginUser");
            if (string.IsNullOrEmpty(value))
                value = string.Empty;
            return value;
        }
    }
}
