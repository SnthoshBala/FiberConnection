using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiberConnection.FiberConnection;
using FiberConnection.Repository;

namespace FiberConnection.Service
{
    public class OfferServ : IOfferServ<Offer>
    {
        private readonly IOfferRepo<Offer> o_repo;
        public OfferServ(IOfferRepo<Offer> _o_repo)
        {
            o_repo = _o_repo;
        }
        public void AddOffer(Offer o)
        {
            o_repo.AddOffer(o);
        }

        public Offer GetOffer(int id)
        {
            return o_repo.GetOffer(id);
        }
    }
}
