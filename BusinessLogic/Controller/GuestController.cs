using System.Collections.Generic;
using Model;
using BusinessLogic.Repository;

namespace BusinessLogic.Controller
{
    public class GuestController
    {
        private readonly GuestRepository _guestRepository;

        public GuestController()
        {
            _guestRepository = new GuestRepository();
        }

        public bool CreateGuest(GuestModel guest)
        {
            if (string.IsNullOrWhiteSpace(guest.FirstName) || string.IsNullOrWhiteSpace(guest.LastName))
                return false;

            return _guestRepository.AddGuest(guest);
        }

        public List<GuestModel> GetGuests()
        {
            return _guestRepository.GetAllGuests();
        }

        public bool UpdateGuest(GuestModel guest)
        {
            if (guest.GuestID <= 0)
                return false;

            return _guestRepository.UpdateGuest(guest);
        }

        public bool RemoveGuest(int guestId)
        {
            if (guestId <= 0)
                return false;

            return _guestRepository.DeleteGuest(guestId);
        }
    }
}