using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AlertMessenger.Alerters.Teams
{
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

    internal class ActionInput
    {
        [JsonPropertyName("@type")]
        public string Type { get; } = "TextInput";
        public string Id{get;}
        public bool isMultiline{get;} = false;
        public string Title{get;}

        public ActionInput(string title)
        {
            Title=title;
            Id = title.Replace(" ","");
        }
    }

    internal class ActionCard
    {
        [JsonPropertyName("@type")]
        public string Type { get; } = "ActionCard";
        public string Name { get;  }
        public IList<ActionInput> Inputs{get;} = new List<ActionInput>();
        public IList<TeamsAction> Actions{get;} = new List<TeamsAction>();
        public ActionCard(string name)
        {
            Name = name;
            //Todo Build Inputs?
        }

    }

    internal class TeamsAction
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
        }
    }
}