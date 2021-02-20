using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class WebAPI2Controller : ApiController
    {
        [HttpGet]//建議寫 雖然API會自動識別 但有寫幫助自己辨別
        public string GetHello()
		{
            return "Hello";
		}

        [HttpGet]//建議寫 雖然API會自動識別 但有寫幫助自己辨別
        public string GetHelloWorld(int id)
		{
            return "Hello! The World is ..." + id.ToString();
		}

        [HttpGet]//建議寫 雖然API會自動識別 但有寫幫助自己辨別
        public string GetComputeIT(int a,int b)
		{
            int result = a + b;
            return result.ToString();
        }

    }
}
