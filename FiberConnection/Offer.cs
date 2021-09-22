using System;
using System.Collections.Generic;

#nullable disable

namespace FiberConnection.FiberConnection
{
    public partial class Offer:IOffer<Offer>
    {
        private readonly fiber_connectionContext fcc = new fiber_connectionContext();
        public Offer()
        {
            FiberPlans = new HashSet<FiberPlan>();
        }

        public int OfferId { get; set; }
        public string Voot { get; set; }
        public string Lionplay { get; set; }
        public string Hungamaplay { get; set; }
        public string Ultra { get; set; }
        public string Hotstar { get; set; }
        public string Netflix { get; set; }
        public string Others { get; set; }

        public virtual ICollection<FiberPlan> FiberPlans { get; set; }

        public void AddOffer(Offer o)
        {
            fcc.Offers.Add(o);
            fcc.SaveChanges();
        }

        public Offer GetOffer(int id)
        {
            return fcc.Offers.Find(id);
        }
    }
}
