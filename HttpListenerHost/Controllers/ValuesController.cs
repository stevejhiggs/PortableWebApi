using System;
using System.Collections.Generic;
using System.Web.Http;

namespace HttpListenerHost.Controllers
{
	public class ValuesController : ApiController
	{
		public IEnumerable<string> Get()
		{
			return new string[] { Guid.NewGuid().ToString(), "httpListener" };
		}
	}
}
