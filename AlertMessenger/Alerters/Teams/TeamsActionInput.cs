using System.Text.Json.Serialization;
using AlertMessenger.MessageCard;

namespace AlertMessenger.Alerters.Teams
{
    public class TeamsActionInput
    {
        [JsonPropertyName("@type")]
        public string Type { get; } = "TextInput";
        public string Id{get;}
        public bool isMultiline{get;} = false;
        public string Title{get;}

        public TeamsActionInput(ActionCardInput input)
        {
            Title=input.Title;
            Id = input.Title.Replace(" ","");
        }
    }
}