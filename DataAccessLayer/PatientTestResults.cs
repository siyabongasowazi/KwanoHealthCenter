using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class PatientTestResults
    {
        public int RequestID { get; set; }
        public int PatientID { get; set; }
        public string Barcode { get; set; }
        public string Temperature { get; set; }
        public string BloodPressure { get; set; }
        public int OxygenLevel { get; set; }

        public PatientTestResults(int reqID, int patID, string barcode, string temp, string bp, int oxygen)
        {
            this.RequestID = reqID;
            this.PatientID = patID;
            this.Barcode = barcode;
            this.Temperature = temp;
            this.BloodPressure = bp;
            this.OxygenLevel = oxygen;
        }
    }
}
