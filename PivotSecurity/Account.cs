using System;
using System.Collections.Generic;
using System.Text;

namespace PivotSecurity
{
    class Account
    {
        private static string test_public_key = "";
        private static string test_private_key = "";
        private static string prod_public_key = "";
        private static string prod_private_key = "";

        var client = new RestClient("http://example.com");
        var request = new RestRequest("resource/{id}");
        request.AddHeader("header", "value");
        request.AddJsonObject(@object);
            var response = client.Post(request);
        var content = response.Content;
    }
}
