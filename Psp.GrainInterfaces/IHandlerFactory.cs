using System.Threading.Tasks;
using Psp.Core.Messages;

namespace Psp.GrainInterfaces
{
    public interface IDispatcherGrain
    {
        Task Dispatch(PspMessage message);
    }
}
