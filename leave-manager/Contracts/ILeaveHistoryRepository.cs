using leave_manager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_manager.Contracts
{
     interface ILeaveHistoryRepository : IRepositoryBase<LeaveHistory>
    {
        ICollection<LeaveType> GetEmployeesByLeaveHistory(int id);
    }
}
