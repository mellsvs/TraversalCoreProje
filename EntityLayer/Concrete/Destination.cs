﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Destination
    {
        [Key]
        public int DestinationID { get; set; }
        public string City { get; set; }
        public string DayNight { get; set; }
        public double Price { get; set; }
        public string image { get; set; }
        public string Description { get; set; }
        public string Capasity { get; set; }
        public bool Status { get; set; }
        public string CoverImage { get; set; }

        public string Details1 { get; set; }
        public string Details2 { get; set; }
        public string Image2 { get; set; }
        public List <Comment> Comments { get; set; }
    }
}
