using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Dependant
    {
        public int DependantID { get; set; }
        public int MemberID { get; set; }
        public string IDNumber { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string CellNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }

        public string IsMedicalAid { get; set; }
        public int MedicalAidPlanID { get; set; }
        public string MedicalAidNo { get; set; }
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }
        public int SuburbID { get; set; }
        public string PersonResponsible { get; set; }

        public Dependant(int memberID, string name, string surname, string IDNo, string CellNo, string emailAddress, string isMedicalAid, int medicalAidPlanID, string medicalNo, string AddressL1, string AddressL2, int suburbID, string personResponsible)
        {
            this.MemberID = memberID;
            this.FirstName = name;
            this.Surname = surname;
            this.IDNumber = IDNo;
            this.CellNumber = CellNo;
            this.EmailAddress = emailAddress;
            this.IsMedicalAid = isMedicalAid;
            this.MedicalAidPlanID = medicalAidPlanID;
            this.MedicalAidNo = medicalNo;
            this.AddressLine1 = AddressL1;
            this.AddressLine2 = AddressL2;
            this.SuburbID = suburbID;
            this.PersonResponsible = personResponsible;
        }
    }
}
