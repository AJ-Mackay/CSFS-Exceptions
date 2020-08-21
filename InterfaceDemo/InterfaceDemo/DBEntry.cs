using System;

namespace InterfaceDemo
{
    public class DBEntry : Storable
    {
        public void Write(object obj)
        {
            Console.WriteLine("Writing obj to database...");
        }

        public string Read()
        {
            return "Reading entry from database";
        }

        private ReturnStatus status;
        public ReturnStatus Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
    }
}