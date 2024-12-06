namespace AutoNest.Data.Entities
{
    using System.Collections.Generic;

    using AutoNest.Data.Common.Models;

    public class Part : BaseDeletableModel<int>
    {
        public int OEnumber { get; set; }

        public string Type { get; set; }

        public string Brand { get; set; }

        public virtual IDictionary<string, string> Description { get; set; }
    }
}
