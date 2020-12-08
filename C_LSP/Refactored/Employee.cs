namespace SOLID.C_LSP.Refactored
{
    public class Employee : BaseEmployee, IManaged
    {
        public IEmployee Manager { get; set; }

        public virtual void AssignManager(IEmployee manager)
        {
            Manager = manager;
        }
    }
}