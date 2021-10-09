using System.Threading.Tasks;
using AlertMessenger.MessageCard;

namespace AlertMessenger.Alerters
{
    public interface IAlerter
    {
        Task SendAsync(Card card);
    }
}