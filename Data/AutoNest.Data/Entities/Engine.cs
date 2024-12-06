namespace AutoNest.Data.Entities
{
    using AutoNest.Data.Common.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Engine : BaseDeletableModel<int>
    {
        public string Drivetrain { get; set; }

        public double Displacement { get; set; }

        List<Parts> EngineParts { get; set; }
    }
}
