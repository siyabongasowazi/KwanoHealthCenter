using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TestRequest
    {
        public int RequestID { get; set; }
        public string RequestDate { get; set; }
        public string RequestTime { get; set; }
        public string RequestStatus { get; set; }
        public int RequestorID { get; set; }
        public int TestSubjectID { get; set; }
        public string TestAddressLine1 { get; set; }
        public string TestAddressLine2 { get; set; }
        public int TestSuburbID { get; set; }

        public TestRequest(string requestDate, string requestTime, string requestStatus, int requestorID, int testSubjectID, string addressLine1, string addressLine2, int suburbID)
        {
            this.RequestDate = requestDate;
            this.RequestTime = requestTime;
            this.RequestStatus = requestStatus;
            this.RequestorID = requestorID;
            this.TestSubjectID = testSubjectID;
            this.TestAddressLine1 = addressLine1;
            this.TestAddressLine2 = addressLine2;
            this.TestSuburbID = suburbID;
        }
    }
}
