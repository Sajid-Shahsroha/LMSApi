using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMSApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveTypeController : ControllerBase
    {
        private IRepositoryWrapper _repoWrapper;
        private ILog _logger;
        public LeaveTypeController(IRepositoryWrapper repoWrapper, ILog logger)
        {
            _repoWrapper = repoWrapper;
            _logger = logger;
        }

        [Authorize]
        [HttpGet]
        public IEnumerable<LeaveType> GetAll()
        {
            _logger.Information("LeaveTypeController-Getll Method");
            return _repoWrapper.LeaveType.FindAll().ToList();
        }
    }
}
