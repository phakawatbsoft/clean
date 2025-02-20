using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interface.Infra.ServiceLifetimes;

namespace Infra.ServiceLifetimes
{
    public class SingletonService : ISingletonService
    {
        private int _requestedCount;
        public SingletonService() {}

        public int GetRequestedCount()
        {
            _requestedCount = _requestedCount + 1;
            return _requestedCount;
        }
    }
}