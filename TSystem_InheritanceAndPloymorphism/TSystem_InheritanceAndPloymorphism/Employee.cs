using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_InheritanceAndPloymorphism
{
    public class Employee
    {

        static int count;
        protected int id;
        protected string name;
        protected double basesalary, hra, da, pf, grosssalary;
        public Employee()
        {

            name = "";
            basesalary = 0.0;
        }
        public Employee( string name, double basesalary)
        {
            count++;
            id = count;
            this.name = name;
            this.basesalary = basesalary;
        }
        public virtual void salarycalculate()
        {
            hra = basesalary * (0.40);
            da = basesalary * (0.20);
            pf = basesalary * (0.12);
            grosssalary = basesalary + hra + da - pf;
        }
        public static int GetCount()
        {
            return count;
        }
        public override string ToString()
        {
            return " Emp ID  " + id + ", Emp Name " + name + ", Emp Salary " + grosssalary;
        }
    }
}
