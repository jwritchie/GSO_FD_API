using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GsoFdLibrary
{
    /// <summary>
    /// HttpClient and its Initialization.
    /// </summary>
    public static class ApiHelper
    {
        public static HttpClient httpClient { get; set; }

        public static void InitializeClient()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
