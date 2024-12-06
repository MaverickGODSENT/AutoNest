namespace AutoNest.Data.Entities
{
    using System;

    using AutoNest.Data.Common.Models;

    public class Car : BaseDeletableModel<int>
    {
        public string Brand { get; set; }

        public string CarModel { get; set; }

        public DateTime[] YearRange { get; set; } = new DateTime[2];

        public virtual Engine Engine { get; set; }

        public virtual Suspension Suspension { get; set; }

        public virtual BodyParts BodyParts { get; set; }
    }
}
