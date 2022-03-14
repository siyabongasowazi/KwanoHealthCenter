using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class NurseTestBooking
    {
        public int RequestID { get; set; }
        public string BookingDate { get; set; }
        public string BookingSlot { get; set; }
        public int NurseID { get; set; }

        public NurseTestBooking(int requestID, string bookingDate, string bookingSlot, int nurseID)
        {
            this.RequestID = requestID;
            this.BookingDate = bookingDate;
            this.BookingSlot = bookingSlot;
            this.NurseID = nurseID;
        }
    }
}
