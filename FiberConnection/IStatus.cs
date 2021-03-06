using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiberConnection.FiberConnection
{
    public interface IStatus<Status>
    {
        public List<Status> GetAllStatus(int id);
        public Status GetStatusByID(int id);
        public void DeleteStatus(Status s);
    }
}
