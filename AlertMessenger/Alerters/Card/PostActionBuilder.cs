namespace AlertMessenger.MessageCard
{
    public class PostActionBuilder
    {
        private CardBuilder cardBuilder;
        public PostActionBuilder(CardBuilder cardBuilder)
        {
            this.cardBuilder = cardBuilder;
        }

        public PostActionBuilder AddInput(string type, string name)
        {
            return this;
        }

        public CardBuilder BuildPostAction()
        {
            return cardBuilder;
        }


    }
}
