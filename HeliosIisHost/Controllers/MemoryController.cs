using System.Diagnostics;
using System.Web.Http;

namespace HeliosIisHost.Controllers
{
	public class MemoryController : ApiController
	{
		public string Get()
		{
			return "Working set is: " + Process.GetCurrentProcess().WorkingSet64.ToString("n0") + " bytes";
		}
	}
}
