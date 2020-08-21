using System;

namespace InterfaceDemo
{
    public enum ReturnStatus
    {
        OK,
        Fail
    };
    
    public interface Storable
    {
        void Write(object obj);
        String Read();
        ReturnStatus Status { get; set; }
    }
}