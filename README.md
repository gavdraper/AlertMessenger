# AlertMessenger
AlertMessenger is a library that provides a clean generic way to send well formatted alert messages to multiple destinations (Think Teams, Slack...). Where the destination supports it you can also make use of actions on the sent Message Cards.

```
var card = CardBuilder
    .Create("FAKE Disk Alert", "MyServer.Domain.Int C Drive < 10%")
        .AddHighlight(Color.Red)
        .AddImage("https://gavindraper.com/profile.jpg") //TODO
        .AddLinkAction("Open Google","http://google.com")
        .AddLinkAction("Open Yahoo","http://yahoo.com")
        .AddPostAction("Add Comment", "https://gavindraper.com/Comment")
            .AddInput("Text", "Comment")    
            .BuildPostAction()
        .Build();
var teamsSender = new TeamsAlerter("https://TeamsChannelUrl");
await teamsSender.SendAsync(card);
```