using System.Collections.Generic;
using BusinessLogic.Repository;
using Model;

namespace BusinessLogic.Controller
{
    public class GuestController
    {
        private readonly GuestRepository _guestRepository;

        public GuestController()
        {
            _guestRepository = new GuestRepository();
        }

        public List<GuestModel> GetGuests()
        {
            return _guestRepository.GetAllGuests();
        }

        public List<GuestModel> SearchGuests(string searchTerm)
        {
            return _guestRepository.SearchGuests(searchTerm);
        }

        public bool CreateGuest(GuestModel guest)
        {
            return _guestRepository.AddGuest(guest);
        }

        public bool UpdateGuest(GuestModel guest)
        {
            return _guestRepository.UpdateGuest(guest);
        }

        public bool RemoveGuest(int guestId)
        {
            return _guestRepository.DeleteGuest(guestId);
        }
    }
}