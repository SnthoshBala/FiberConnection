using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable

namespace FiberConnection.FiberConnection
{
    public partial class Status:IStatus<Status>
    {
        private readonly fiber_connectionContext fcc = new fiber_connectionContext();
        public int StatusId { get; set; }
        public string Status1 { get; set; }
        public int? EmployeeId { get; set; }
        public int? CustomerId { get; set; }
        public int? PlanId { get; set; }
        public int? BillingNumber { get; set; }
        public double? PlanPrice { get; set; }
        public string PlanName { get; set; }
        public string CustomerName { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeePhonenumber { get; set; }

        public virtual Billing BillingNumberNavigation { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual FiberPlan Plan { get; set; }

        public void DeleteStatus(Status s)
        {
            fcc.Statuses.Remove(s);
            fcc.SaveChanges();
        }

        public List<Status> GetAllStatus(int id)
        {
            return (from i in fcc.Statuses where i.CustomerId == id select i).ToList();
        }

        public Status GetStatusByID(int id)
        {
            return fcc.Statuses.Find(id);
        }
    }
}
