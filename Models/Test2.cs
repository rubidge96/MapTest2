namespace MapTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class Test2
    {
        public int id { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        public double? Lat { get; set; }

        public double? Long { get; set; }
    }


}
