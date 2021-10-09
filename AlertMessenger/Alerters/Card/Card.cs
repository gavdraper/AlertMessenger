using System.Collections.Generic;
using System.Drawing;

namespace AlertMessenger.MessageCard
{
    public class LinkAction
    {
        public string ActionText { get; }
        public string Url { get; }

        public LinkAction(string actionText, string url)
        {
            ActionText = actionText;
            Url = url;
        }
    }
    public class Card
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public Color Highlight { get; set; }
        public IList<LinkAction> LinkActions{get;} = new List<LinkAction>();

    }
}
