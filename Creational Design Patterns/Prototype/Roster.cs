using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Prototype
{
    public class Roster
    {
        private readonly Dictionary<string,Vacation> _vacationObjects = new Dictionary<string, Vacation>();
        public Roster()
        {
            try
            {
                var xml = XDocument.Load("RosterObjects.xml");
                foreach (var element in xml.Root.Element("vacations").Elements())
                {
                    var vacation = Vacation.GenerateFromXml(element);
                    _vacationObjects.Add(vacation.ObjectName, vacation);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
        public Vacation CloneVacationObject(string key)
        {
            if (_vacationObjects.ContainsKey(key))
                return _vacationObjects[key].CloneMe() as Vacation;
            return null;
        }
    }
}
