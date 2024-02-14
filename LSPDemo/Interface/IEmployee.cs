namespace LSPDemo.Interface
{
    public interface IEmployee
    {
        int Id { get; set; }
        string Name { get; set; }
        decimal GetMinimumSalary();
    }
}
