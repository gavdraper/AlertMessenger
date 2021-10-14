using AlertMessenger.Alerters.Teams;

namespace AlertMessenger.MessageCard
{
    public class PostActionBuilder
    {
        private CardBuilder cardBuilder;
        private readonly Card card;
        private readonly TeamsActionCard actionCard;

        public PostActionBuilder(
            CardBuilder cardBuilder, 
            Card card,
            string Url,
            string ActionText)
        {
            this.cardBuilder = cardBuilder;
            this.card = card;
            actionCard = new TeamsActionCard(ActionText.Replace(" ",""));
            actionCard.Actions.Add(new TeamsAction("HttpPOST",ActionText,Url));
        }

        public PostActionBuilder AddInput(string type, string name)
        {
            actionCard.Inputs.Add(
                new TeamsActionInput(name)
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
