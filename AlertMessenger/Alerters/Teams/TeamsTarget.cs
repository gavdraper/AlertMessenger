namespace AlertMessenger.Alerters.Teams
{
    public class TeamsTarget
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
