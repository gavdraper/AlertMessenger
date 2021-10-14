namespace AlertMessenger.MessageCard
{
    public class LinkAction
    {
        internal string ActionText { get; }
        internal string Url { get; }

        public LinkAction(string actionText, string url)
        {
            ActionText = actionText;
            Url = url;
        }
    }
}
