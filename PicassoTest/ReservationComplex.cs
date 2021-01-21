using System;
using System.Collections.Generic;
using System.Text;

namespace PicassoTest
{
    public class ReservationComplex
    {
        public User MadeBy { get; set; }
        public float Price { get; set; }
        public bool CanBeCancelledBy(User user)
        {
            if(user.IsAdmin)
            {
                return true;
            }
            if(user == MadeBy)
            {
                return true;
            }

            return false;
        }

        public float PayReservation(UserComplex user)
        {
            throw new NotImplementedException();
        }
    }

    public class UserComplex
    {
        public float Money { get; set; }
        public bool IsAdmin { get; set; }
    }
}
