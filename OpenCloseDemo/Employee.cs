namespace OpenCloseDemo
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Employee()
        {

        }
        public Employee(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public abstract decimal CalculateBonus(decimal salary);
        public override string ToString()
        {
            return string.Format("Id: {0}, Name: {1}", this.Id, this.Name);
        }
    }
    public class PermanentEmployee : Employee
    {
        public PermanentEmployee()
        {

        }
        public PermanentEmployee(int id, string name) : base(id, name)
        {
            
        }
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }
    }
    public class TempEmployee : Employee
    {
        public TempEmployee()
        {

        }
        public TempEmployee(int id, string name) : base(id, name)
        {

        }
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .05M;
        }
    }
    public class ContractEmployee : Employee
    {
        public ContractEmployee()
        {

        }
        public ContractEmployee(int id, string name) : base(id, name)
        {

        }
        public override decimal CalculateBonus(decimal salary)
        {
            throw new NotImplementedException();
        }
    }
}
