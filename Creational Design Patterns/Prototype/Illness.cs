namespace Prototype
{
    public class Illness : RosterObject
    {
        public override RosterObject CloneMe()
        {
            return Clone() as Illness;
        }
        //Further methods
    }
}
