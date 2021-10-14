using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AlertMessenger.Alerters.Teams
{
    public class TeamsActionCard
    {
        [JsonPropertyName("@type")]
        public string Type { get; } = "ActionCard";
        public string Name { get;  }
        public IList<TeamsActionInput> Inputs{get;} = new List<TeamsActionInput>();
        public IList<TeamsAction> Actions{get;} = new List<TeamsAction>();
        public TeamsActionCard(string name)
        {
            Name = name;
        }

    }
}