namespace AlertMessenger.MessageCard
{
    public class ActionCardAction
    {
        public string Type { get; }
        public string ActionText { get; }
        public string Url { get; }

        public ActionCardAction(string type, string actionText, string url)
        {
            Type = type;
            ActionText = actionText;
            Url = url;
        }
    }
}