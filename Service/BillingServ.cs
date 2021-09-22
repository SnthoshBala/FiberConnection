using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiberConnection.FiberConnection;
using FiberConnection.Repository;

namespace FiberConnection.Service
{
    public class BillingServ : IBillingServ<Billing>
    {
        private readonly IBillingRepo<Billing> b_repo;
        public BillingServ(IBillingRepo<Billing> _b_repo)
        {
            b_repo = _b_repo;
        }
        public int AddBilling(Billing b, int id, int c_id)
        {
            return b_repo.AddBilling(b,id,c_id);
        }

        public void AddStatusBilling(Billing b)
        {
            b_repo.AddStatusBilling(b);
        }

        public Billing FindByID(int id)
        {
            return b_repo.FindByID(id);
        }
    }
}
