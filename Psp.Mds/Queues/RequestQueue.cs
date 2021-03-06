﻿using System.Collections.Concurrent;
using Psp.Core.Messages;

namespace Psp.Mds.Queues
{
    internal static class RequestQueue
    {
        private static readonly ConcurrentQueue<PspMessage> Queue = new ConcurrentQueue<PspMessage>();

        public static void Enqueue(PspMessage message)
        {
            Queue.Enqueue(message);
        }

        public static PspMessage Dequeue()
        {
            if (Queue.TryDequeue(out var message))
            {
                return message;
            }
            return null;
        }
    }
}