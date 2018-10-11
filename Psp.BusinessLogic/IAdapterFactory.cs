using System.Collections.Generic;
using System.Text;
using Psp.GrainInterfaces;

namespace Psp.BusinessLogic
{
    internal interface IAdapterFactory
    {
        IAdapterGrain Create(string providerAccountName);
    }
}
