using System.Threading.Tasks;

namespace AlertMessenger.Alerters
{
    public interface IAlerter
    {
        Task SendAsync(Card card);
    }
}