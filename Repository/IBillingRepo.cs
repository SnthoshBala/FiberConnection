using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiberConnection.Repository
{
    public interface IBillingRepo<Billing>
    {
        public Billing FindByID(int id);
        public void AddStatusBilling(Billing b);
        public int AddBilling(Billing b, int id, int c_id);
    }
}
