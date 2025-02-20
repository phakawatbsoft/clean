using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interface.Infra.ServiceLifetimes;

namespace Infra.ServiceLifetimes
{
    public class TransientService : ITransientService
    {
        private int _requestedCount;
        private readonly ISingletonService _singletonService;
        private readonly IScopedService _scopedService;

        public TransientService(ISingletonService singletonService, IScopedService scopedService)
        {
            _singletonService = singletonService;
            _scopedService = scopedService;
        }

        public int GetRequestedCount(){
            _requestedCount = _requestedCount + 1;
            return _requestedCount;
        }
        public int GetScopedRequestedCount(){
            return _scopedService.GetRequestedCount();
        }
        public int GetSingletonRequestedCount(){
            return _singletonService.GetRequestedCount();
        }
    }
}