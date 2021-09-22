using System;
using System.Collections.Generic;
using System.Linq;


#nullable disable

namespace FiberConnection.FiberConnection
{
    public partial class Billing:IBilling<Billing>
    {
        private readonly fiber_connectionContext fcc = new fiber_connectionContext();
        public Billing()
        {
            Statuses = new HashSet<Status>();
        }

        public int BillingNumber { get; set; }
        public int? CustomerId { get; set; }
        public int? PlanId { get; set; }
        public DateTime? BookedDate { get; set; }
        public string CustomerName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerAadharNo { get; set; }
        public string CustomerMailId { get; set; }
        public string PlanName { get; set; }
        public string PlanPrice { get; set; }
        public double? Tax { get; set; }
        public double? Total { get; set; }
        public string PaymentMethod { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual FiberPlan Plan { get; set; }
        public virtual ICollection<Status> Statuses { get; set; }

        public int AddBilling(Billing b, int id, int c_id)
        {
            Customer c = new Customer();
            FiberPlan fp = new FiberPlan();
            b.BookedDate = DateTime.Now;
            b.CustomerId = c_id;
            b.PlanId = id;
            c = fcc.Customers.Find(b.CustomerId);
            fp = fcc.FiberPlans.Find(b.PlanId);
            b.CustomerName = c.CustomerName;
            b.CustomerMailId = c.CustomerMailId;
            b.CustomerAadharNo = c.CustomerAadharNo;
            b.CustomerAddress = c.CustomerAddress;
            b.CustomerPhoneNumber = c.CustomerPhoneNumber;
            b.DateOfBirth = c.DateOfBirth;
            b.PaymentMethod = "Cash";
            b.PlanName = fp.PlanName;
            b.PlanPrice = fp.PlanPrice;
            b.Tax = (float.Parse(fp.PlanPrice) / 100) * 5;
            b.Total = Convert.ToInt32(b.PlanPrice) + Convert.ToInt64(b.Tax);
            fcc.Billings.Add(b);
            fcc.SaveChanges();
            var ba = (from i in fcc.Billings
                      where i.CustomerId == b.CustomerId
                      orderby i.BillingNumber
                      select i).Last();
            return Convert.ToInt32(ba.BillingNumber);
        }

        public void AddStatusBilling(Billing b)
        {
            Status s = new Status();
            fcc.Entry(b).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            fcc.SaveChanges();
            Billing ba = new Billing();
            ba = (from i in fcc.Billings where i.BillingNumber == b.BillingNumber select i).FirstOrDefault();
            s.BillingNumber = ba.BillingNumber;
            s.CustomerId = ba.CustomerId;
            s.EmployeeId = null;
            s.EmployeeName = null;
            s.PlanId = ba.PlanId;
            s.PlanName = ba.PlanName;
            s.PlanPrice = ba.Total;
            s.CustomerName = ba.CustomerName;
            s.Status1 = "Assigning Worker";
            fcc.Statuses.Add(s);
            fcc.SaveChanges();
        }

        public Billing FindByID(int id)
        {
            return fcc.Billings.Find(id);
        }
    }
}
