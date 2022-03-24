using System;


namespace TSystem_Custom_Exception
{
    internal class NameException : Exception
    {
        public NameException(string msg) : base(msg)
        {

        }
    }
    public class User
    {
        public string AcceptName(string name)
        {
            //if (name.Equals(null)|| name.Equals(""))
            if (string.IsNullOrEmpty(name))
                {
                throw new NameException(" Name is Required to Continue........");
            }
            return name;
        }
    }

}
