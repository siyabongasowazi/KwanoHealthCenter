using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DataAccessLayer
{
    public class DAL
    {
        string CS = ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString;
        SqlCommand dbComm;
        SqlDataAdapter dbAdapter;
        DataTable dt;
        DataSet ds;

        public DataTable GetTestResultsByNurse(int NurseID)
        {
            using (SqlConnection dbConn = new SqlConnection(CS))
            {
                dbComm = new SqlCommand("sp_GetTestResultsByNurse", dbConn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                dbComm.Parameters.AddWithValue("@NurseID", NurseID);
                dbAdapter = new SqlDataAdapter(dbComm);
                dt = new DataTable();
                dbAdapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetMedicalAids()
        {
            using (SqlConnection dbConn = new SqlConnection(CS))
            {
                dbComm = new SqlCommand("sp_GetAllMedicalAids", dbConn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                dbAdapter = new SqlDataAdapter(dbComm);
                dt = new DataTable();
                dbAdapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetAllTestRequests()
        {
            using (SqlConnection dbConn = new SqlConnection(CS))
            {
                dbComm = new SqlCommand("sp_GetAllTestsRequest", dbConn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                dbAdapter = new SqlDataAdapter(dbComm);
                dt = new DataTable();
                dbAdapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetNurses()
        {
            using (SqlConnection dbConn = new SqlConnection(CS))
            {
                dbComm = new SqlCommand("sp_GetNurses", dbConn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                dbAdapter = new SqlDataAdapter(dbComm);
                dt = new DataTable();
                dbAdapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetCities()
        {
            using (SqlConnection dbConn = new SqlConnection(CS))
            {
                dbComm = new SqlCommand("sp_GetCities", dbConn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                dbAdapter = new SqlDataAdapter(dbComm);
                dt = new DataTable();
                dbAdapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetMedicalAidPlans(int MedicalAidID)
        {
            using (SqlConnection dbConn = new SqlConnection(CS))
            {
                dbComm = new SqlCommand("sp_GetMedicalAidPlans", dbConn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                dbComm.Parameters.AddWithValue("@MedicalAidID", MedicalAidID);
                dbAdapter = new SqlDataAdapter(dbComm);
                dt = new DataTable();
                dbAdapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetTestSubjectName(int TestSubjectID)
        {
            using (SqlConnection dbConn = new SqlConnection(CS))
            {
                dbComm = new SqlCommand("sp_GetTestSubjectName", dbConn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                dbComm.Parameters.AddWithValue("@TestSubjectID", TestSubjectID);
                dbAdapter = new SqlDataAdapter(dbComm);
                dt = new DataTable();
                dbAdapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetTestRequest(int TestRequestID)
        {
            using (SqlConnection dbConn = new SqlConnection(CS))
            {
                dbComm = new SqlCommand("sp_GetTestRequest", dbConn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                dbComm.Parameters.AddWithValue("@TestRequestID", TestRequestID);
                dbAdapter = new SqlDataAdapter(dbComm);
                dt = new DataTable();
                dbAdapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetNurseTodaysBookings(int NurseID)
        {
            using (SqlConnection dbConn = new SqlConnection(CS))
            {
                dbComm = new SqlCommand("sp_NurseTodaySchedule", dbConn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                dbComm.Parameters.AddWithValue("@NurseID", NurseID);
                dbAdapter = new SqlDataAdapter(dbComm);
                dt = new DataTable();
                dbAdapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetNurseTestBookings(int NurseID)
        {
            using (SqlConnection dbConn = new SqlConnection(CS))
            {
                dbComm = new SqlCommand("sp_GetTommorwBookings ", dbConn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                dbComm.Parameters.AddWithValue("@NurseID", NurseID);
                dbAdapter = new SqlDataAdapter(dbComm);
                dt = new DataTable();
                dbAdapter.Fill(dt);
                return dt;
            }
        }


        public DataTable GetMemberDependantsNames(int MemberID)
        {
            using (SqlConnection dbConn = new SqlConnection(CS))
            {
                dbComm = new SqlCommand("sp_GetMemberDependantsNames", dbConn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                dbComm.Parameters.AddWithValue("@MemberID", MemberID);
                dbAdapter = new SqlDataAdapter(dbComm);
                dt = new DataTable();
                dbAdapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetSuburbs(int CityID)
        {
            using (SqlConnection dbConn = new SqlConnection(CS))
            {
                dbComm = new SqlCommand("sp_GetSuburbs", dbConn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                dbComm.Parameters.AddWithValue("@CityID", CityID);
                dbAdapter = new SqlDataAdapter(dbComm);
                dt = new DataTable();
                dbAdapter.Fill(dt);
                return dt;
            }
        }

        public int InsertMainMember(User user, MainMember main)
        {
            using (SqlConnection dbConn = new SqlConnection(CS))
            {
                dbComm = new SqlCommand("sp_InsertMainMember", dbConn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                dbComm.Parameters.AddWithValue("@FullName", main.FirstName);
                dbComm.Parameters.AddWithValue("@Surname", main.Surname);
                dbComm.Parameters.AddWithValue("@IDNumber", main.IDNumber);
                dbComm.Parameters.AddWithValue("@CellNumber", main.CellNumber);
                dbComm.Parameters.AddWithValue("@EmailAddress", main.EmailAddress);
                dbComm.Parameters.AddWithValue("@Username", user.Username);
                dbComm.Parameters.AddWithValue("@Password", user.Password);
                dbComm.Parameters.AddWithValue("@Status", user.Status);
                dbComm.Parameters.AddWithValue("@UserType", user.UserType);
                dbComm.Parameters.AddWithValue("@IsMedicalAid", main.IsMedicalAid);
                dbComm.Parameters.AddWithValue("@MedicalAidPlanID", main.MedicalAidPlanID);
                dbComm.Parameters.AddWithValue("@MedicalAidNo ", main.MedicalAidNo);
                dbComm.Parameters.AddWithValue("@AddressLine1", main.AddressLine1);
                dbComm.Parameters.AddWithValue("@AddressLine2", main.AddressLine2);
                dbComm.Parameters.AddWithValue("@SuburbID", main.SuburbID);
                dbComm.Parameters.AddWithValue("@PersonResponsible", main.PersonResponsible);
                if (dbConn.State == ConnectionState.Closed)
                {
                    dbConn.Open();
                }
                int x = dbComm.ExecuteNonQuery();

                return x;
            }
        }

        public DataTable GetUserPassword(UserPassword password)
        {
            using (SqlConnection dbConn = new SqlConnection(CS))
            {
                dbComm = new SqlCommand("sp_GetUserPassword", dbConn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                dbComm.Parameters.AddWithValue("@Username", password.Email);
                dbComm.Parameters.AddWithValue("@Password", password.Password);
                dbAdapter = new SqlDataAdapter(dbComm);
                dt = new DataTable();
                dbAdapter.Fill(dt);
                return dt;
            }
        }

       

        public DataTable GetNursePassword(UserPassword password)
        {
            using (SqlConnection dbConn = new SqlConnection(CS))
            {
                dbComm = new SqlCommand("sp_GetNursePassword", dbConn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                dbComm.Parameters.AddWithValue("@Username", password.Email);
                dbComm.Parameters.AddWithValue("@Password", password.Password);
                dbAdapter = new SqlDataAdapter(dbComm);
                dt = new DataTable();
                dbAdapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetManagerPassword(UserPassword password)
        {
            using (SqlConnection dbConn = new SqlConnection(CS))
            {
                dbComm = new SqlCommand("sp_GetManagerPassword", dbConn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                dbComm.Parameters.AddWithValue("@Username", password.Email);
                dbComm.Parameters.AddWithValue("@Password", password.Password);
                dbAdapter = new SqlDataAdapter(dbComm);
                dt = new DataTable();
                dbAdapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetMainMemberByID(int memberID)
        {
            using (SqlConnection dbConn = new SqlConnection(CS))
            {
                dbComm = new SqlCommand("sp_GetMainMemberByID", dbConn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                dbComm.Parameters.AddWithValue("@MemberID", memberID);
                dbAdapter = new SqlDataAdapter(dbComm);
                dt = new DataTable();
                dbAdapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetNurseDetails(int NurseID)
        {
            using (SqlConnection dbConn = new SqlConnection(CS))
            {
                dbComm = new SqlCommand("sp_GetNurseDetails", dbConn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                dbComm.Parameters.AddWithValue("@NurseID", NurseID);
                dbAdapter = new SqlDataAdapter(dbComm);
                dt = new DataTable();
                dbAdapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetMemberSuburbName(int memberID)
        {
            using (SqlConnection dbConn = new SqlConnection(CS))
            {
                dbComm = new SqlCommand("sp_GetMemberSuburbName", dbConn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                dbComm.Parameters.AddWithValue("@MemberID", memberID);
                dbAdapter = new SqlDataAdapter(dbComm);
                dt = new DataTable();
                dbAdapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetMemberDependants(int memberID)
        {
            using (SqlConnection dbConn = new SqlConnection(CS))
            {
                dbComm = new SqlCommand("sp_GetMemberDependants", dbConn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                dbComm.Parameters.AddWithValue("@MemberID", memberID);
                dbAdapter = new SqlDataAdapter(dbComm);
                dt = new DataTable();
                dbAdapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetNurseSuburbs(int nurseID)
        {
            using (SqlConnection dbConn = new SqlConnection(CS))
            {
                dbComm = new SqlCommand("sp_GetNurseSuburbs", dbConn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                dbComm.Parameters.AddWithValue("@NurseID", nurseID);
                dbAdapter = new SqlDataAdapter(dbComm);
                dt = new DataTable();
                dbAdapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetTestRequestsForNurse(int nurseID)
        {
            using (SqlConnection dbConn = new SqlConnection(CS))
            {
                dbComm = new SqlCommand("sp_GetTestRequestsForNurse", dbConn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                dbComm.Parameters.AddWithValue("@NurseID", nurseID);
                dbAdapter = new SqlDataAdapter(dbComm);
                dt = new DataTable();
                dbAdapter.Fill(dt);
                return dt;
            }
        }

        public int InsertDependant(Dependant main)
        {
            using (SqlConnection dbConn = new SqlConnection(CS))
            {
                dbComm = new SqlCommand("sp_InsertDependant", dbConn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                dbComm.Parameters.AddWithValue("@MemberID", main.MemberID);
                dbComm.Parameters.AddWithValue("@FullName", main.FirstName);
                dbComm.Parameters.AddWithValue("@Surname", main.Surname);
                dbComm.Parameters.AddWithValue("@IDNumber", main.IDNumber);
                dbComm.Parameters.AddWithValue("@CellNumber", main.CellNumber);
                dbComm.Parameters.AddWithValue("@EmailAddress", main.EmailAddress);
                dbComm.Parameters.AddWithValue("@IsMedicalAid", main.IsMedicalAid);
                dbComm.Parameters.AddWithValue("@MedicalAidPlanID", main.MedicalAidPlanID);
                dbComm.Parameters.AddWithValue("@MedicalAidNo ", main.MedicalAidNo);
                dbComm.Parameters.AddWithValue("@AddressLine1", main.AddressLine1);
                dbComm.Parameters.AddWithValue("@AddressLine2", main.AddressLine2);
                dbComm.Parameters.AddWithValue("@SuburbID", main.SuburbID);
                dbComm.Parameters.AddWithValue("@PersonResponsible", main.PersonResponsible);
                if (dbConn.State == ConnectionState.Closed)
                {
                    dbConn.Open();
                }
                int x = dbComm.ExecuteNonQuery();

                return x;
            }
        }

        public int InsertNurseSuburb(int NurseID, int SuburbID)
        {
            using (SqlConnection dbConn = new SqlConnection(CS))
            {
                dbComm = new SqlCommand("sp_InsertNurseSuburbs", dbConn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                dbComm.Parameters.AddWithValue("@NurseID", NurseID);
                dbComm.Parameters.AddWithValue("@SuburbID", SuburbID);
                if (dbConn.State == ConnectionState.Closed)
                {
                    dbConn.Open();
                }
                int x = dbComm.ExecuteNonQuery();

                return x;
            }
        }

        public int RemoveDependant(int IDNo)
        {
            using (SqlConnection dbConn = new SqlConnection(CS))
            {
                dbComm = new SqlCommand("sp_RemoveDependant", dbConn);
                dbComm.CommandType = CommandType.StoredProcedure;
                dbComm.Parameters.AddWithValue("@IDNumber", IDNo);
                if (dbConn.State == ConnectionState.Closed)
                {
                    dbConn.Open();
                }
                int x = dbComm.ExecuteNonQuery();
                return x;
            }
        }

        public int InsertTestRequest(TestRequest test)
        {
            using (SqlConnection dbConn = new SqlConnection(CS))
            {
                dbComm = new SqlCommand("sp_InsertTestRequest", dbConn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                dbComm.Parameters.AddWithValue("@RequestDate", test.RequestDate);
                dbComm.Parameters.AddWithValue("@RequestTime", test.RequestTime);                
                dbComm.Parameters.AddWithValue("@RequestStatus", test.RequestStatus);
                dbComm.Parameters.AddWithValue("@RequestorID", test.RequestorID);
                dbComm.Parameters.AddWithValue("@TestSubjectID", test.TestSubjectID);
                dbComm.Parameters.AddWithValue("@TestAddressLine1", test.TestAddressLine1);
                dbComm.Parameters.AddWithValue("@TestAddressLine2", test.TestAddressLine2);
                dbComm.Parameters.AddWithValue("@TestSuburbID", test.TestSuburbID);
                if (dbConn.State == ConnectionState.Closed)
                {
                    dbConn.Open();
                }
                int x = dbComm.ExecuteNonQuery();

                return x;
            }
        }

        public int InsertTestBooking(NurseTestBooking nurse)
        {
            using (SqlConnection dbConn = new SqlConnection(CS))
            {
                dbComm = new SqlCommand("sp_InsertTestBooking", dbConn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                dbComm.Parameters.AddWithValue("@RequestID", nurse.RequestID);
                dbComm.Parameters.AddWithValue("@BookingDate", nurse.BookingDate);
                dbComm.Parameters.AddWithValue("@BookingTimeSlot", nurse.BookingSlot);
                dbComm.Parameters.AddWithValue("@NurseID", nurse.NurseID);
                if (dbConn.State == ConnectionState.Closed)
                {
                    dbConn.Open();
                }
                int x = dbComm.ExecuteNonQuery();

                return x;
            }
        }

        public int InsertTestResults(PatientTestResults patient)
        {
            using (SqlConnection dbConn = new SqlConnection(CS))
            {
                dbComm = new SqlCommand("sp_InsertTestResults", dbConn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                dbComm.Parameters.AddWithValue("@RequestID", patient.RequestID);
                dbComm.Parameters.AddWithValue("@PatientID", patient.PatientID);
                dbComm.Parameters.AddWithValue("@Barcode", patient.Barcode);
                dbComm.Parameters.AddWithValue("@Temperature", patient.Temperature);
                dbComm.Parameters.AddWithValue("@BloodPressure", patient.BloodPressure);
                dbComm.Parameters.AddWithValue("@OxygenLevel", patient.OxygenLevel);
                if (dbConn.State == ConnectionState.Closed)
                {
                    dbConn.Open();
                }
                int x = dbComm.ExecuteNonQuery();

                return x;
            }
        }


    }
}
