using System.Collections.Generic;
using System.Drawing;
using AlertMessenger.Alerters.Teams;

namespace AlertMessenger.MessageCard
{
    public class ActionCard
    {
        public string Name { get; }
        public IList<ActionCardInput> Inputs { get; } = new List<ActionCardInput>();
        public IList<ActionCardAction> Actions { get; } = new List<ActionCardAction>();
        public ActionCard(string name)
        {
            Name = name;
        }
    }
}