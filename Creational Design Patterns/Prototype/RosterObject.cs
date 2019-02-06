using System;

namespace Prototype
{
    public abstract class RosterObject : ICloneable
    {
        public string ObjectName { get; protected set; }
        public double Duration { get; protected set; }
        public object Clone()
        {
            try
            {
                return MemberwiseClone();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                throw;
            }
        }
        public abstract RosterObject CloneMe();
    }
}
