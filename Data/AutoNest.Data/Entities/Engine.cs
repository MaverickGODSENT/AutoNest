namespace AutoNest.Data.Entities
{
    using System.Collections.Generic;

    using AutoNest.Data.Common.Models;

    public class Engine : BaseDeletableModel<int>
    {
        public string Drivetrain { get; set; }

        public double Displacement { get; set; }

        List<Part> EngineParts { get; set; }
    }
}
