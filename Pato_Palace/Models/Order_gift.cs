﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pato_Palace.Models
{
    public class Order_gift
    {

        public int Id { get; set; }
        [Required, StringLength(100)]
        public string Title { get; set; }
        [Required, StringLength(250)]

        public string SubTitle { get; set; }
        [Required, StringLength(390)]
        public string Description { get; set; }
        [Required, StringLength(390)]
        public string Image { get; set; }
    }
}