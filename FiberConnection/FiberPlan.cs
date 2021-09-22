using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable

namespace FiberConnection.FiberConnection
{
    public partial class FiberPlan:IFiberPlan<FiberPlan>
    {
        private readonly fiber_connectionContext fcc = new fiber_connectionContext();
        public FiberPlan()
        {
            Billings = new HashSet<Billing>();
            Statuses = new HashSet<Status>();
        }

        public int PlanId { get; set; }
        public string PlanName { get; set; }
        public string PlanPrice { get; set; }
        public string PlanSpeed { get; set; }
        public string Validity { get; set; }
        public int? OfferId { get; set; }
        public string Image { get; set; }

        public virtual Offer Offer { get; set; }
        public virtual ICollection<Billing> Billings { get; set; }
        public virtual ICollection<Status> Statuses { get; set; }

        public void AddPlans(FiberPlan fp)
        {
            fcc.FiberPlans.Add(fp);
        }

        public List<FiberPlan> GetFiberPlans()
        {
            return fcc.FiberPlans.ToList();
        }
    }
}
