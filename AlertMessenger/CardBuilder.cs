using System;

namespace AlertMessenger
{
    public class Card
    {

    }

    public class CardBuilder
    {
        private CardBuilder()
        {

        }

        public static CardBuilder Create()
        {
            return new CardBuilder();
        }

        public Card Build()
        {
            return new Card();
        }
    }
}
