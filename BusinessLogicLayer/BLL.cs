using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class BLL
    {
        DAL dal = new DAL();

        public DataTable GetNurses()
        {
            return dal.GetNurses();
        }

        public DataTable GetManagerPassword(UserPassword password)
        {
            return dal.GetManagerPassword(password);
        }

        public DataTable GetTestResultsByNurse(int NurseID)
        {
            return dal.GetTestResultsByNurse(NurseID);
        }

        public DataTable GetNurseTodaysBookings(int NurseID)
        {
            return dal.GetNurseTodaysBookings(NurseID);
        }

        public DataTable GetNursePassword(UserPassword password)
        {
            return dal.GetNursePassword(password);
        }

        public DataTable GetAllTestRequests()
        {
            return dal.GetAllTestRequests();
        }

        public int InsertTestResults(PatientTestResults patient)
        {
            return dal.InsertTestResults(patient);
        }

        public DataTable GetTestRequestsForNurse(int nurseID)
        {
            return dal.GetTestRequestsForNurse(nurseID);
        }

        public DataTable GetMemberDependantsNames(int MemberID)
        {
            return dal.GetMemberDependantsNames(MemberID);
        }

        public DataTable GetNurseSuburbs(int nurseID)
        {
            return dal.GetNurseSuburbs(nurseID);
        }
        public int InsertTestRequest(TestRequest test)
        {
            return dal.InsertTestRequest(test);
        }
        public DataTable GetMedicalAids()
        {
            return dal.GetMedicalAids();
        }
        public int InsertNurseSuburb(int NurseID, int SuburbID)
        {
            return dal.InsertNurseSuburb(NurseID, SuburbID);
        }
        public DataTable GetMedicalAidPlans(int MedicalAidID)
        {
            return dal.GetMedicalAidPlans(MedicalAidID);
        }

        public DataTable GetCities()
        {
            return dal.GetCities();
        }

        public DataTable GetSuburbs(int CityID)
        {
            return dal.GetSuburbs(CityID);
        }

        public int InsertTestBooking(NurseTestBooking nurse)
        {
            return dal.InsertTestBooking(nurse);
        }

        public DataTable GetNurseTestBookings(int NurseID)
        {
            return dal.GetNurseTestBookings(NurseID);
        }

        public DataTable GetTestRequest(int TestRequestID)
        {
            return dal.GetTestRequest(TestRequestID);
        }

        public DataTable GetTestSubjectName(int TestSubjectID)
        {
            return dal.GetTestSubjectName(TestSubjectID);
        }

        public int InsertMainMember(User user, MainMember main)
        {
            return dal.InsertMainMember(user, main);
        }
        public DataTable GetUserPassword(UserPassword password)
        {
            return dal.GetUserPassword(password);
        }

        public DataTable GetMainMemberByID(int memberID)
        {
            return dal.GetMainMemberByID(memberID);
        }

        public DataTable GetMemberSuburbName(int MemberID)
        {
            return dal.GetMemberSuburbName(MemberID);
        }

        public int InsertDependant(Dependant main)
        {
            return dal.InsertDependant(main);
        }

        public DataTable GetMemberDependants(int memberID)
        {
            return dal.GetMemberDependants(memberID);
        }

        public DataTable GetNurseDetails(int NurseID)
        {
            return dal.GetNurseDetails(NurseID);
        }

        public int RemoveDependant(int IDNo)
        {
            return dal.RemoveDependant(IDNo);
        }
    }
}
