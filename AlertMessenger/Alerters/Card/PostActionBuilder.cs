using AlertMessenger.Alerters.Teams;

namespace AlertMessenger.MessageCard
{
    public class PostActionBuilder
    {
        private CardBuilder cardBuilder;
        private readonly Card card;
        private readonly ActionCard actionCard;

        public PostActionBuilder(
            CardBuilder cardBuilder, 
            Card card,
            string Url,
            string ActionText)
        {
            this.cardBuilder = cardBuilder;
            this.card = card;
            actionCard = new ActionCard(ActionText);
            actionCard.Actions.Add(new ActionCardAction("HttpPOST",ActionText,Url));
        }

        public PostActionBuilder AddInput(string type, string name)
        {
            actionCard.Inputs.Add(
                new ActionCardInput(name)
            );
            return this;
        }

        public CardBuilder BuildPostAction()
        {
            card.ActionCards.Add(actionCard);
            return cardBuilder;
        }


    }
}
