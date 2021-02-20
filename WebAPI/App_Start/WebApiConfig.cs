using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebAPI
{
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			// Web API 設定和服務

			// Web API 路由
			config.MapHttpAttributeRoutes();

			config.Routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "api/{controller}/{id}",
				defaults: new { id = RouteParameter.Optional }
			);

			config.Routes.MapHttpRoute(
				name: "DefaultApi3",
				routeTemplate: "api/{controller}/{a}/{b}",
				defaults: new { id = RouteParameter.Optional }
				//a 與 b 兩個變數名稱 需要跟 觸發方法的輸入參數一樣!!
			);
		}
	}
}
