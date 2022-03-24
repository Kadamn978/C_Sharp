using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_Generic_List_Stack_Queue_Dictionary
{
    public class Mygenericcls<T>
    {
        private T data;
        public Mygenericcls(T data)
        {
            this.data = data;
        }
        public T GetData()
        {
            return data;
        }
      
    }
}
