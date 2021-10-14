using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using AlertMessenger.MessageCard;

namespace AlertMessenger.Alerters.Teams
{
    public class TeamsAlerter : IAlerter
    {
        private readonly string endpointUri;
        private static HttpClient client = new HttpClient();

        public TeamsAlerter(string endpointUri)
        {
            this.endpointUri = endpointUri;
        }

            /*
      "@type": "ActionCard",
        "name": "Add a comment",
        "inputs": [{
            "@type": "TextInput",
            "id": "comment",
            "isMultiline": false,
            "title": "Add a comment here for this task"
        }],
        "actions": [{
            "@type": "HttpPOST",
            "name": "Add comment",
            "target": "https://docs.microsoft.com/outlook/actionable-messages"
        }]
    */

        public async Task SendAsync(Card card)
        {
            var cardJson = JsonSerializer.Serialize(new TeamsCard(card));
            Console.WriteLine(cardJson);
            var httpContent = new StringContent(cardJson, Encoding.UTF8, "application/json");
            //Todo load this from config...
            var response = client.PostAsync(endpointUri, httpContent).Result;
            var responseString = await response.Content.ReadAsStringAsync();
            Console.WriteLine(response.StatusCode);
        }
    }
}