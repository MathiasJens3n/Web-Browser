using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Browser
{
    //Fetches the respone from the server
    internal class HttpFetcher
    {
        //HttpClient
        private HttpClient client = new HttpClient();

        /// <summary>
        /// Fetches response from server and converts it to string.
        /// </summary>
        /// <returns>Response from server as string.</returns>
        public async Task<string> GetResponse(string url)
        {
            try
            {
                //Gets the response sent back from the server
                using HttpResponseMessage response = await client.GetAsync(url);
                //Throws an error if the request fails
                response.EnsureSuccessStatusCode();
                //Convert respone to string
                string responseBody = await response.Content.ReadAsStringAsync();

                return responseBody;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return "An error has occured";
            }
        }
    }
}
