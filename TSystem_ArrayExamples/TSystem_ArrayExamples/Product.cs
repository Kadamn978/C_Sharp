using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_ArrayExamples
{
    internal class Product
    {
        int pid;
        double price;
        string pname;
        public Product()
        {
            pid = 0;
            pname = "";
            price = 0.0;
        }
        public Product(int pid, string pname, double price)
        {
            this.pid = pid;
            this.pname = pname;
            this.price = price;
        }
        public void display()
        {
            if ((price * 0.1) > 5000)
            {

            }
        }
	
	
    }
}
