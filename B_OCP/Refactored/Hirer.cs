using System.Collections.Generic;

namespace SOLID.B_OCP.Refactored
{
    public class Hirer
    {
        public static List<EmployeeModel> Hire(List<IApplicantModel> applicants)
        {
            List<EmployeeModel> employees = new List<EmployeeModel>();
            
            foreach (var applicant in applicants)
            {
                employees.Add(applicant.AccountProcessor.Create(applicant));
            }

            return employees;
        }
    }
}