using Contracts;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class LeaveRequestRepository : RepositoryBase<LeaveRequest>, ILeaveRequestRepository
    {
        protected RepositoryContext repositoryContext { get; set; }
        public LeaveRequestRepository(RepositoryContext _repositoryContext)
            : base(_repositoryContext)
        {
            repositoryContext = _repositoryContext;
        }
        
    }
}
