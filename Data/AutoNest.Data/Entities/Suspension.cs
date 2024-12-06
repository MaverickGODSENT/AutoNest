namespace AutoNest.Data.Entities
{
    using AutoNest.Data.Common.Models;

    public class Suspension : BaseDeletableModel<int>
    {
        public virtual Part FrontShock { get; set; }

        public virtual Part RearShock { get; set; }

        public virtual Part FrontSpring { get; set; }

        public virtual Part RearSpring { get; set; }
    }
}
