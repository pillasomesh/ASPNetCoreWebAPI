using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Contracts;
using LoggerService;
namespace AccountOwnerServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILoggerManager _logger;

        private IRepositoryWrapper _repoWrapper;
        public WeatherForecastController(ILoggerManager logger, IRepositoryWrapper repoWrapper)
        {
            _logger = logger;
            _repoWrapper = repoWrapper;
        }
        [HttpGet]
        public IEnumerable<string> Get()
        {
            try
            {
                var domesticAccounts = _repoWrapper.Account.FindByCondition(x => x.AccountType.Equals("Domestic"));
                var owners = _repoWrapper.Owner.FindAll();

                _logger.LogInfo("Here is info message from the controller.");
               
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
            }
            return new string[] { "value1", "value2" };
        }
    }
}
