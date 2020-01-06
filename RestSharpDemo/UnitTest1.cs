using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;

namespace RestSharpDemo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var client = new RestClient();
            var request = new RestRequest("postss/{postid}",Method.GET);
            request.AddUrlSegment("postid", 1);


            var content = client.Execute(request).Content;
        }
    }
}
