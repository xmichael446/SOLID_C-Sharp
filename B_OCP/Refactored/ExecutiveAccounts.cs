namespace SOLID.B_OCP.Refactored
{
    public class ExecutiveAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel applicant)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = applicant.FirstName;
            output.LastName = applicant.LastName;
            output.EmailAddress = $"{applicant.FirstName}{applicant.LastName}@acmecorp.com";
            output.IsManager = true;
            output.IsExecutive = true;

            return output;
        }
    }
}