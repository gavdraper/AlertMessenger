using System;
using System.Drawing;
using System.Threading.Tasks;
using AlertMessenger.Alerters;
using AlertMessenger.Alerters.Teams;

namespace AlertMessenger.ConsoleRunner
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var card = CardBuilder
                .Create("FAKE Disk Alert", "MyServer.Domain.Int C Drive < 10%")
                .AddHighlight(Color.Red)
                .AddLinkAction("Open Google","http://google.com")
                .AddLinkAction("Open Yahoo","http://yahoo.com")
                .Build();
            var teamsSender = new TeamsAlerter("https://wavertonim.webhook.office.com/webhookb2/18639eca-d7a4-4859-afdf-4d251cfc6518@40f54f1a-11e4-414a-9ad4-aebc28d14a0c/IncomingWebhook/9dbee380ed114402b7d5c7d33e71cd31/12a0f964-293c-430f-a0b9-9d844d39afb6");
            await teamsSender.SendAsync(card);
            //Todo....
            //* Load endpoint from config
            //* Add following action builders
                // .AddPostAction("Add Comment")
                //     .AddInput(InputType.Text, "txtComment")
                //     .AddInput(InputType.Text, "txtUser")
                //     .AddSubmit("Save")
                //     .BuildAction()
                //.AddImage("imageUrl")
                //.AddDateTime()
        }
    }
}
