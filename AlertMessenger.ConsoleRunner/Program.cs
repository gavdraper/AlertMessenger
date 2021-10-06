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
                // .AddPostAction("Add Comment")
                //     .AddInput(InputType.Text, "txtComment")
                //     .AddInput(InputType.Text, "txtUser")
                //     .AddSubmit("Save")
                //     .BuildAction()
                //.AddImage("imageUrl")
                //.AddDateTime()
                .Build();
            var teamsSender = new TeamsAlerter("http://myTeamsEndpoint.com");
            teamsSender.SendAsync(card).Wait();
            
        }
    }
}
