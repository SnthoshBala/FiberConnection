using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiberConnection.FiberConnection
{
    public interface IOffer<Offer>
    {
        public void AddOffer(Offer o);
        public Offer GetOffer(int id);
    }
}
