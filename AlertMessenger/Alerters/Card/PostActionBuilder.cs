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
            actionCard = new ActionCard(ActionText.Replace(" ",""));
            actionCard.Actions.Add(new TeamsAction("Post",ActionText,Url));
        }

        public PostActionBuilder AddInput(string type, string name)
        {
            actionCard.Inputs.Add(
                new ActionInput(name)
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
