namespace SOLID.B_OCP.Refactored
{
    public class ManagerAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel applicant)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = applicant.FirstName;
            output.LastName = applicant.LastName;
            output.EmailAddress = $"{applicant.FirstName.Substring(0, 1)}{applicant.LastName}@acmecorp.com";
            output.IsManager = true;

            return output;
        }
    }
}