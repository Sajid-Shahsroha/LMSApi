using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace LMSApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveRequestController : ControllerBase
    {
        private IRepositoryWrapper _repoWrapper;
        private ILog _logger;
        public LeaveRequestController(IRepositoryWrapper repoWrapper, ILog logger)
        {
            _repoWrapper = repoWrapper;
            _logger = logger;
        }
        //[HttpGet]
        //public IEnumerable<LeaveRequest> GetAll()
        //{
        //    _logger.Information("LeaveRequestController-Getll Method");
        //    return _repoWrapper.LeaveRequest.FindAll().ToList();
        //}

        [HttpGet]
        public IEnumerable<LeaveRequest> GetAll(string empId)
        {
            return _repoWrapper.LeaveRequest.FindByCondition(s => s.EmployeeId == empId);
        }

        [HttpPost]
        public void Post([FromBody] LeaveRequest leaveRequest)
        {
            _logger.Information("LeaveRequestController-Post Method");
            _repoWrapper.LeaveRequest.Create(leaveRequest);
            _repoWrapper.Save();
        }
    }
}
