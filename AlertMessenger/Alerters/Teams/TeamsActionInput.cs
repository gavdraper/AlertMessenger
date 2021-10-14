using System.Text.Json.Serialization;

namespace AlertMessenger.Alerters.Teams
{
    public class TeamsActionInput
    {
        [JsonPropertyName("@type")]
        public string Type { get; } = "TextInput";
        public string Id{get;}
        public bool isMultiline{get;} = false;
        public string Title{get;}

        public TeamsActionInput(string title)
        {
            Title=title;
            Id = title.Replace(" ","");
        }
    }
}