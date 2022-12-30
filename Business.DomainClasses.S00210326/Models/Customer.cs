﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DomainClasses.S00210326.Models
{
    public class Customer
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }


    }
}