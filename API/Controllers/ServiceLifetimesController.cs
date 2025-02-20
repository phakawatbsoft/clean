using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interface.Infra.ServiceLifetimes;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServiceLifetimesController : ControllerBase
    {
        private readonly ITransientService _transientService;
        private readonly ITransientService _transientServiceTwo;
        private readonly ITransientService _transientServiceThree;
        private readonly IScopedService _scopeService;
        private readonly ISingletonService _singletonService;

        public ServiceLifetimesController(ITransientService transientService, ITransientService transientServiceTwo, ITransientService transientServiceThree, IScopedService scopeService, ISingletonService singletonService)
        {
            _transientService = transientService;
            _transientServiceTwo = transientServiceTwo;
            _transientServiceThree = transientServiceThree;

            _scopeService = scopeService;
            _singletonService = singletonService;
        }
    }
}