using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AlertMessenger.Alerters
{
    public class TeamsAlerter : IAlerter
    {
        private readonly string endpointUri;
        private static HttpClient client = new HttpClient();

        public TeamsAlerter(string endpointUri)
        {
            this.endpointUri = endpointUri;
        }

        public async Task SendAsync(Card card)
        {
            //Todo Replace with serialized Card
            var msg =
                      "{" +
                      "   \"@context\": \"https://schema.org/extensions\"," +
                      "   \"@type\": \"MessageCard\"," +
                      "   \"themeColor\": \"7ED810\", " +
                      "   \"title\": \"Alert Over\"," +
                      "   \"text\": \"Alert Text Goes Here!\"," +
                      "   \"potentialAction\": [" +
                      "     {" +
                      "      \"@type\": \"OpenUri\"," +
                      "      \"name\": \"Learn More\"," +
                      "      \"targets\": [{ \"os\": \"default\", \"uri\": \"http://google.com\" }]" +
                      "     }" +
                      "    ]" +
                      "}";
            var httpContent = new StringContent(msg, Encoding.UTF8, "application/json");
            var url = @"https://MyEndpoint";
            var response = client.PostAsync(url, httpContent).Result;
            var responseString = await response.Content.ReadAsStringAsync();
            Console.WriteLine(response.StatusCode);
        }


    }
}