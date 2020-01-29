using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Product.Application;
using Product.Domain;

namespace Product.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ElementController : ControllerBase
    {
        private readonly IElementService _elementService;
        private readonly ILogger<ElementController> _logger;

        public ElementController(ILogger<ElementController> logger, IElementService elementService)
        {
            _elementService = elementService;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Element> Get()
        {
            return _elementService.GetElements();
        }
    }
}
