using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AlertMessenger.Alerters.Teams
{

    public class TeamsAction
    {
        [JsonPropertyName("@type")]
        public string Type { get; }
        public string Name { get; }
        public IList<TeamsTarget> Targets { get; } = new List<TeamsTarget>();

        public TeamsAction(string type, string actionText, string url)
        {
            Type = type;
            Name = actionText;
            if (type == "OpenUri")
            {
                Targets.Add(new TeamsTarget("default", url));
            }
            else 
            if (type == "HttpPOST")
            {
                Targets.Add(new TeamsTarget("default", url));
            }
        }
    }
}