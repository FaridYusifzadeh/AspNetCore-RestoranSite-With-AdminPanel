﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pato_Palace.Models
{
    public class Location
    {
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string Title { get; set; }
        [Required, StringLength(150)]

        public string SubTitle { get; set; }
        [Required, StringLength(390)]
        public string Description { get; set; }

        [Required, StringLength(100)]
        public string TitleCode { get; set; }
        [Required, StringLength(370)]
        public string SubTitleCode { get; set; }

    }
}
