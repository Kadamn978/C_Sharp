using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_This_Keyword
{
    internal class Employee
    {
        private int eid;
        private string ename;
        private double basesalary, hra, da, pf, grosssalary;
        public  Employee()
        {
            eid = 0;
            ename = "";
            basesalary = 0.0;
        }
        public Employee(int eid, string ename, double basesalary)
        {
            this.eid = eid;
            this.ename = ename;
            this.basesalary = basesalary;
        }
        public void salarycalculate()
        {
            hra = basesalary * (0.40);
            da = basesalary * (0.20);
            pf = basesalary * (0.12);
            grosssalary = basesalary + hra + da - pf;
        }
        public override string ToString()
        {
            return " Emp ID  " + eid + ", Emp Name " + ename + ", Emp Salary " + grosssalary;
        }
    }
}
