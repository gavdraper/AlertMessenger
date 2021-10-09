using System;
using System.Drawing;
using System.Threading.Tasks;
using AlertMessenger.Alerters;
using AlertMessenger.Alerters.Teams;
using AlertMessenger.MessageCard;

namespace AlertMessenger.ConsoleRunner
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var card = CardBuilder
                .Create("FAKE Disk Alert", "MyServer.Domain.Int C Drive < 10%")
                    .AddHighlight(Color.Red)
                    .AddImage("http://gavindraper.com/profile.jpg") //TODO
                    .AddLinkAction("Open Google","http://google.com")
                    .AddLinkAction("Open Yahoo","http://yahoo.com")
                    .AddPostAction("Add Comment", "http://gavindraper.com/Comment")
                        .AddInput("Text", "Comment")    
                        .BuildPostAction()
                    .Build();
            var teamsSender = new TeamsAlerter("http://MyendPoint.com");
            await teamsSender.SendAsync(card);
            //Todo....
            //* Load endpoint from config
        }
    }
}
