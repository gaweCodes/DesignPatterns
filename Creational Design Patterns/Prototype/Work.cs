namespace Prototype
{
    public class Work : RosterObject
    {
        public override RosterObject CloneMe()
        {
            return Clone() as Work;
        }
        //Further methods
    }
}
