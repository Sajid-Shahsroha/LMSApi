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
   public class LeaveTypeRepository : RepositoryBase<LeaveType>, ILeaveTypeRepository
    {
        protected RepositoryContext repositoryContext { get; set; }
        public LeaveTypeRepository(RepositoryContext _repositoryContext)
            : base(_repositoryContext)
        {
            repositoryContext = _repositoryContext;
        }

        public new IQueryable<LeaveType> FindAll()
        {
            return this.repositoryContext.LeaveTypes.FromSqlRaw("spGetLeaveTypes");
        }
    }
}