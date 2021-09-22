using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiberConnection.Repository
{
    public interface IFiberPlanRepo<FiberPlan>
    {
        public List<FiberPlan> GetFiberPlans();
        public void AddPlans(FiberPlan fp);
    }
}
