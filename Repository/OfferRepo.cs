using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiberConnection.FiberConnection;

namespace FiberConnection.Repository
{
    public class OfferRepo : IOfferRepo<Offer>
    {
        private readonly IOffer<Offer> o_obj;
        public OfferRepo(IOffer<Offer> _o_obj)
        {
            o_obj = _o_obj;
        }
        public void AddOffer(Offer o)
        {
            o_obj.AddOffer(o);
        }

        public Offer GetOffer(int id)
        {
            return o_obj.GetOffer(id);
        }
    }
}
