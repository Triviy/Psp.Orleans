using System.Collections.Concurrent;
using Psp.Core.Messages;

namespace Psp.OuterWorld.Queues
{
    internal static class ResponseQueue
    {
        private static readonly ConcurrentQueue<UpdateResponse> Queue = new ConcurrentQueue<UpdateResponse>();

        public static void Enqueue(UpdateResponse message)
        {
            Queue.Enqueue(message);
        }

        public static UpdateResponse Dequeue()
        {
            if (Queue.TryDequeue(out var message))
            {
                return message;
            }
            return null;
        }
    }
}