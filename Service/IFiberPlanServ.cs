using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiberConnection.Service
{
    public interface IFiberPlanServ<FiberPlan>
    {
        public List<FiberPlan> GetFiberPlans();
        public void AddPlans(FiberPlan fp);
    }
}
