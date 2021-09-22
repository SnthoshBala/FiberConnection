using System;
using System.Collections.Generic;

#nullable disable

namespace FiberConnection.FiberConnection
{
    public partial class Payment
    {
        public int PaymentId { get; set; }
        public int? BillingNumber { get; set; }
        public double? Tax { get; set; }
        public double? Total { get; set; }
        public string PaymentMethod { get; set; }

        public virtual Billing BillingNumberNavigation { get; set; }
    }
}
