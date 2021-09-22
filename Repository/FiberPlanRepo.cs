using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiberConnection.FiberConnection;

namespace FiberConnection.Repository
{
    public class FiberPlanRepo : IFiberPlanRepo<FiberPlan>
    {
        private readonly IFiberPlan<FiberPlan> fp_obj;
        public FiberPlanRepo(IFiberPlan<FiberPlan> _fp_obj)
        {
            fp_obj = _fp_obj;
        }
        public void AddPlans(FiberPlan fp)
        {
            fp_obj.AddPlans(fp);
        }

        public List<FiberPlan> GetFiberPlans()
        {
            return fp_obj.GetFiberPlans();
        }
    }
}
