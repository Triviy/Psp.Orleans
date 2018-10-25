using System.Collections.Concurrent;
using Psp.Core.Messages;

namespace Psp.Mds.Queues
{
    internal class RequestQueue : IRequestQueue
    {
        private readonly ConcurrentQueue<PspMessage> Queue = new ConcurrentQueue<PspMessage>();

        public void Enqueue(PspMessage message)
        {
            Queue.Enqueue(message);
        }

        public PspMessage Dequeue()
        {
            if (Queue.TryDequeue(out var message))
            {
                return message;
            }
            return null;
        }
    }
}