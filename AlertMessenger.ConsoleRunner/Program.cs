using System;
using System.Drawing;
using AlertMessenger.Alerters;
using AlertMessenger.Alerters.Teams;

namespace AlertMessenger.ConsoleRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stubb Usage flow....
            var card = CardBuilder
                .Create("FAKE Disk Alert", "MyServer.Domain.Int C Drive < 10%")
                .AddHighlight(Color.Red)
                .AddLinkAction("Open Google","http://google.com")
                .AddLinkAction("Open Yahoo","http://yahoo.com")
                .Build();

                // .AddPostAction("Add Comment")
                //     .AddInput(InputType.Text, "txtComment")
                //     .AddInput(InputType.Text, "txtUser")
                //     .AddSubmit("Save")
                //     .BuildAction()
                //.AddImage("imageUrl")
                //.AddDateTime()
            var teamsSender = new TeamsAlerter("http://MyTeamsChannelEndpoint");
            teamsSender.SendAsync(card).Wait();
            
        }
    }
}
