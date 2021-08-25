using Contracts;
using Entities;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _repoContext;
        private ILeaveTypeRepository _leaveType;
        private ILeaveRequestRepository _leaveRequest;

        public ILeaveTypeRepository LeaveType
        {
            get
            {
                if (_leaveType == null)
                {
                    _leaveType = new LeaveTypeRepository(_repoContext);
                }

                return _leaveType;
            }
        }

        public ILeaveRequestRepository LeaveRequest
        {
            get
            {
                if (_leaveRequest == null)
                {
                    _leaveRequest = new LeaveRequestRepository(_repoContext);
                }

                return _leaveRequest;
            }
        }

        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }

        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}