using System;
using System.Collections.Generic;

#nullable disable

namespace CarLotDL.Entities
{
    public partial class Description
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string Mpg { get; set; }
        public int CarId { get; set; }


        public virtual Car Car { get; set; }
    }
}