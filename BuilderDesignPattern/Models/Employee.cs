using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [AllowNull]
        public double HourlyPay { get; set; }
        [AllowNull]
        public double Bonus { get; set; }
        public int TypeId { get; set; }
        [AllowNull]
        public double HouseAllowance { get; set; }
        [AllowNull]
        public double MedicalAllowance { get; set; }
        public string JobDescription { get; set; }
        public string ComputerInfo { get; set; }
        public string SystemConfigurationDetails { get; set; }
    }
}
