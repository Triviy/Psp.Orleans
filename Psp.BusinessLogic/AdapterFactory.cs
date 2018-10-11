using System;
using Orleans.CodeGeneration;
using Psp.GrainInterfaces;

namespace Psp.BusinessLogic
{
    internal class AdapterFactory : IAdapterFactory
    {
        public IAdapterGrain Create(string providerAccountName)
        {
            //GrainFactory.
            throw new NotImplementedException();
        }
    }
}