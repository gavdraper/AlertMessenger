using System;
using System.Drawing;

namespace AlertMessenger
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

        public Card Build()
        {
            return card;
        }
    }
}
