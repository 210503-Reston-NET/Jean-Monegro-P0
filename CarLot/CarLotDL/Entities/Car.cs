using System;
using System.Collections.Generic;

#nullable disable

namespace CarLotDL.Entities
{
    public partial class Car
    {
        public Car()
        {
            Descriptions = new HashSet<Description>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }
        public string Mpg { get; set; }

        public virtual ICollection<Description> Descriptions { get; set; }
    }
}