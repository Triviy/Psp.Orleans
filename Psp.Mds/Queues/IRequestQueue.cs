using System;
using System.Collections.Generic;
using System.Text;
using Psp.Core.Messages;

namespace Psp.Mds.Queues
{
    public interface IRequestQueue
    {
        void Enqueue(PspMessage message);
        PspMessage Dequeue();
    }
}
