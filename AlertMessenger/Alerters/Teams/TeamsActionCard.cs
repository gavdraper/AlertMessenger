using System.Collections.Generic;
using System.Text.Json.Serialization;
using AlertMessenger.MessageCard;

namespace AlertMessenger.Alerters.Teams
{
    public class TeamsActionCard
    {
        [JsonPropertyName("@type")]
        public string Type { get; } = "ActionCard";
        public string Name { get;  }
        public IList<TeamsActionInput> Inputs{get;} = new List<TeamsActionInput>();
        public IList<TeamsActionCardAction> Actions{get;} = new List<TeamsActionCardAction>();
        public TeamsActionCard(ActionCard card)
        {
            this.Name = card.Name;
            foreach(var i in card.Inputs)
            {
                Inputs.Add(new TeamsActionInput(i));
            }
            foreach(var a in card.Actions)
            {
                Actions.Add(new TeamsActionCardAction(a));
            }
        }

    }
}