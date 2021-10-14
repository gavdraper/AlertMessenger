using System.Collections.Generic;
using System.Text.Json.Serialization;
using AlertMessenger.MessageCard;

namespace AlertMessenger.Alerters.Teams
{
    internal class TeamsCard
    {
        [JsonPropertyName("@context")]
        public string Context { get; } = "https://schema.org/extensions";
        [JsonPropertyName("@type")]
        public string Type { get; } = "MessageCard";
        public string ThemeColor { get; set; } = "7ED810";
        public string Title { get; set; }
        public string Text { get; set; }
        public IList<dynamic> PotentialAction { get; } = new List<dynamic>();
        public TeamsCard(Card card)
        {
            Title = card.Title;
            Text = card.Body;
            ThemeColor = $"{card.Highlight.R:X2}{card.Highlight.G:X2}{card.Highlight.B:X2}";
            foreach (var l in card.LinkActions)
            {
                PotentialAction.Add(
                    new TeamsAction("OpenUri", l.ActionText, l.Url)
                );
            }
            //Todo Card Shold have Generic ActionCard Not Teams One
            foreach(var l in card.ActionCards)
            {
                PotentialAction.Add(l);
            }
        }
    }
}