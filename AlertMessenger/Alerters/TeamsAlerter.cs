using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
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

        private class TeamsCard
        {
            [JsonPropertyName("@context")]
            public string Context{get;} = "https://schema.org/extensions";
            [JsonPropertyName("type")]
            public string Type{get;} = "MessageCard";
            public string ThemeColor{get;set;} = "7ED810";
            public string Title{get;set;} 
            public string Text{get;set;}
            public TeamsCard(Card card)
            {
                Title = card.Title;
                Text = card.Body;
                ThemeColor = $"{card.Highlight.R:X2}{card.Highlight.G:X2}{card.Highlight.B:X2}";
            }
        }

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