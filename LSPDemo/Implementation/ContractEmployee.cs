﻿using LSPDemo.Abstract;
using LSPDemo.Interface;

namespace LSPDemo.Implementation
{
    public class ContractEmployee : IEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ContractEmployee() 
        { 

        }
        public ContractEmployee(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public decimal GetMinimumSalary()
        {
            return 4000;
        }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }
}
