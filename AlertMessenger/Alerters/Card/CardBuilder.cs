using System;
using System.Drawing;

namespace AlertMessenger.MessageCard
{
    public class CardBuilder
    {
        private Card card;
        private CardBuilder()
        {
            card = new Card();
        }

        public static CardBuilder Create(string title = "", string body = "")
        {
            var builder = new CardBuilder();
            builder.card.Title = title;
            builder.card.Body = body;
            return builder;
        }

        public CardBuilder AddHighlight(Color color)
        {
            card.Highlight = color;
            return this;
        }

        public CardBuilder AddLinkAction(string actionText, string url)
        {
            card.LinkActions.Add(new LinkAction(actionText, url));
            return this;
        }

        public CardBuilder AddImage(string url)
        {
            return this;
        }

        public PostActionBuilder AddPostAction(string actionText, string url)
        {
            return new PostActionBuilder(this);
        }

        public Card Build()
        {
            return card;
        }
    }
}
