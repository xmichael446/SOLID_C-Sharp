namespace SOLID.B_OCP.Refactored
{
    public class PersonModel : IApplicantModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccounts AccountProcessor { get; set; } = new StaffAccounts();
    }
}