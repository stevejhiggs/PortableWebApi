using System;
using NUnit.Framework;
using Microsoft.Owin.Testing;
using System.Net.Http;
using System.Collections.Generic;

namespace HttpListenerHost.AcceptanceTests
{
	[TestFixture]
	public class IntegrationTests
	{
		private TestServer _server;

		[TestFixtureSetUp]
		public void FixtureInit()
		{
			//I'm an owin server spooled up entirely in memory with no real network traffic
			_server = TestServer.Create<HttpListenerHost.Startup>();
		}

		[TestFixtureTearDown]
		public void FixtureDispose()
		{
			_server.Dispose();
		}

		[Test]
		public async void Calling_Values_Should_Respond_With_Values()
		{
			var response = await _server.HttpClient.GetAsync("/values");
			var result = await response.Content.ReadAsAsync<string[]>();
			Assert.AreEqual(result.Length, 2);
			Assert.AreEqual(result[1], "httpListener");
		}
	}
}
