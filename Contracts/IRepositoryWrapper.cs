using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IRepositoryWrapper
    {
        ILeaveTypeRepository LeaveType { get; }
        ILeaveRequestRepository LeaveRequest { get; }
        void Save();
    }
}
