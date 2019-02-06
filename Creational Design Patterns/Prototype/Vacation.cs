using System.Xml.Linq;

namespace Prototype
{
    public class Vacation : RosterObject
    {
        public bool IsPaid { get; private set; }
        public override RosterObject CloneMe()
        {
            return Clone() as Vacation;
        }
        public static Vacation GenerateFromXml(XElement element)
        {
            var vacation = new Vacation();
            var name = element.Attribute("name")?.Value;
            vacation.ObjectName = name;
            vacation.Duration = double.Parse(element.Value);
            bool.TryParse(element.Attribute("paid")?.Value, out var paid);
            vacation.IsPaid = paid;
            return vacation;
        }
    }
}
