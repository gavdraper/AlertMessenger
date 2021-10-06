using System;
using System.Drawing;
using AlertMessenger.Alerters;

namespace AlertMessenger.ConsoleRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stubb Usage flow....
            var card = CardBuilder
                .Create("My Title", "My Body")
                .AddHighlight(Color.Red)
                //.AddLinkAction("View Info","http://google.com");
                .Build();
            var teamsSender = new TeamsAlerter("http://myTeamsEndpoint.com");
            teamsSender.Send(card);
            
        }
    }
}
