using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiberConnection.FiberConnection;
using FiberConnection.Repository;

namespace FiberConnection.Service
{
    public class StatusServ : IStatusServ<Status>
    {
        private readonly IStatusRepo<Status> s_repo;
        public StatusServ(IStatusRepo<Status> _s_repo)
        {
            s_repo = _s_repo;
        }
        public void DeleteStatus(Status s)
        {
            s_repo.DeleteStatus(s);
        }

        public List<Status> GetAllStatus(int id)
        {
            return s_repo.GetAllStatus(id);
        }

        public Status GetStatusByID(int id)
        {
            return s_repo.GetStatusByID(id);
        }
    }
}
