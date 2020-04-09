using BookStore.Core.Bus;
using BookStore.Core.Commands;
using MediatR;
using System.Threading.Tasks;

namespace BookStore.Infrastructure.Bus
{
    public sealed class InMemoryBus : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public InMemoryBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task SendCommand<T>(T command) where T : Command
        {
            return _mediator.Send(command);
        }
    }
}
