using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_SerializationDemo
{
    [Serializable]  //attribute
    // informs to run that this class allowed to serilize
    public class Department
    {
        public int DeptID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }
}
