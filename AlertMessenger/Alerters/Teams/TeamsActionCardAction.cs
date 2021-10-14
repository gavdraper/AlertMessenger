using System.Collections.Generic;
using System.Text.Json.Serialization;
using AlertMessenger.MessageCard;

namespace AlertMessenger.Alerters.Teams
{
    public class TeamsActionCardAction
    {
        [JsonPropertyName("@type")]
        public string Type { get; }
        public string Name { get; }
        public string Target{ get; } 

        public TeamsActionCardAction(ActionCardAction action)
        {
            Type = action.Type;
            Name = action.ActionText;
            if (Type == "HttpPOST")
            {
                Target = action.Url;
            }
        }
    }
}