using BookStore.Core.Commands;
using System.Threading.Tasks;

namespace BookStore.Core.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;
    }
}
