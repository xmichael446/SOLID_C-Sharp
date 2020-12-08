namespace SOLID.C_LSP.Refactored
{
    public interface IManaged
    {
        IEmployee Manager { get; set; }
        void AssignManager(IEmployee manager);
    }
}