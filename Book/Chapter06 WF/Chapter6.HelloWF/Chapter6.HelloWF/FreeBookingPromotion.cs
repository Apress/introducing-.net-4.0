using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;

namespace Chapter6.HelloWF
{
    public class FreeBookingPromotion : CodeActivity
    {
        public InArgument<string> BookingReference { get; set; }
        public OutArgument<bool> FreeBooking { get; set; }

        protected override void Execute(CodeActivityContext context)
        {

            System.Random Random = new Random();

            if (Random.Next(1, 100) == 100)
            {
                //Customer has won free booking
                FreeBooking.Set(context, true);
            }
            else
            {
                FreeBooking.Set(context, false);
            }

        }
    }

}
