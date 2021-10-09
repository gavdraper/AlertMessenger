using System.Collections.Generic;
using System.Text.Json.Serialization;

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
        public IList<TeamsAction> PotentialAction { get; } = new List<TeamsAction>();
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
        }
    }
}