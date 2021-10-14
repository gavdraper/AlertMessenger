using System.Collections.Generic;
using System.Drawing;
using AlertMessenger.Alerters.Teams;

namespace AlertMessenger.MessageCard
{
    public class Card
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public Color Highlight { get; set; }
        public IList<LinkAction> LinkActions{get;} = new List<LinkAction>();
        public IList<ActionCard> ActionCards{get;} = new List<ActionCard>();
    }
}
