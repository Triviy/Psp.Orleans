using System.Threading.Tasks;
using Orleans;
using Psp.Core.Messages;

namespace Psp.GrainInterfaces
{
    public interface IDispatcherGrain : IGrainWithIntegerKey
    {
        Task Dispatch(PspMessage message);
    }
}
