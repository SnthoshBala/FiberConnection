using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiberConnection.FiberConnection
{
    public interface IFiberPlan<FiberPlan>
    {
        public List<FiberPlan> GetFiberPlans();
        public void AddPlans(FiberPlan fp);
    }
}
