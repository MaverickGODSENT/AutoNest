namespace AutoNest.Data.Entities
{
    using AutoNest.Data.Common.Models;

    public class BodyParts : BaseDeletableModel<int>
    {
        public virtual Part FrontDoor { get; set; }

        public virtual Part RearDoor { get; set; }

        public virtual Part HeadLights { get; set; }

        public virtual Part TaiLights { get; set; }

        public virtual Part Hood { get; set; }

        public virtual Part Trunk { get; set; }
    }
}
