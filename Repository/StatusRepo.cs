using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiberConnection.FiberConnection;

namespace FiberConnection.Repository
{
    public class StatusRepo:IStatusRepo<Status>
    {
        private readonly IStatus<Status> s_obj;
        public StatusRepo(IStatus<Status> _s_obj)
        {
            s_obj = _s_obj;
        }
        public List<Status> GetAllStatus(int id)
        {
            return s_obj.GetAllStatus(id);
        }

        public Status GetStatusByID(int id)
        {
            return s_obj.GetStatusByID(id);
        }

        public void DeleteStatus(Status s)
        {
            s_obj.DeleteStatus(s);
        }

    }
}
