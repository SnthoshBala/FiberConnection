using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiberConnection.FiberConnection;
using FiberConnection.Repository;

namespace FiberConnection.Service
{
    public class FiberPlanServ : IFiberPlanServ<FiberPlan>
    {
        private readonly IFiberPlanRepo<FiberPlan> fp_repo;
        public FiberPlanServ(IFiberPlanRepo<FiberPlan> _fp_repo)
        {
            fp_repo = _fp_repo;
        }
        public void AddPlans(FiberPlan fp)
        {
            fp_repo.AddPlans(fp);
        }

        public List<FiberPlan> GetFiberPlans()
        {
            return fp_repo.GetFiberPlans();
        }
    }
}
