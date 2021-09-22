using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiberConnection.Service
{
    public interface IBillingServ<Billing>
    {
        public Billing FindByID(int id);
        public void AddStatusBilling(Billing b);
        public int AddBilling(Billing b, int id, int c_id);
    }
}
