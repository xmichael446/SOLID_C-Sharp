namespace SOLID.B_OCP.Refactored
{
    public class StaffAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel applicant)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = applicant.FirstName;
            output.LastName = applicant.LastName;
            output.EmailAddress = $"{applicant.FirstName.Substring(0, 1)}{applicant.LastName}@acme.com";

            return output;
        }
    }
}