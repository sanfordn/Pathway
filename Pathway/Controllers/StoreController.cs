
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pathway.DTOs;

namespace Pathway.Controllers
{
    public class StoreController : Controller
    {
        private readonly ILogger _logger;
        private readonly IStoreInfo _storeInfo;
        public StoreController(ILogger logger, IStoreInfo storeInfo)
        {
            _logger = logger;
            _storeInfo = storeInfo;
        }
        [HttpGet("Store/GetStore/{name}")]
        public Store GetStore(string name)
        {
            return _storeInfo.GetStoreInfo(name);
        }
    }
}
