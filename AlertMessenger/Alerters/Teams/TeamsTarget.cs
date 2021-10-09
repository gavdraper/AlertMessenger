namespace AlertMessenger.Alerters.Teams
{
    internal class TeamsTarget
    {
        public string Os { get; }
        public string Uri { get; }
        public TeamsTarget(string os, string uri)
        {
            Os = os;
            Uri = uri;
        }
    }


}
