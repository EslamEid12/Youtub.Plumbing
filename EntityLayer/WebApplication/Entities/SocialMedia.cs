﻿using CoreLayer.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.WebApplication.Entities
{
    public class SocialMedia:BaseEntity
    {
        public string? Twitter { get; set; } = null!;
        public string? LinkedIn { get; set; } = null!;
        public string? Facebook { get; set; } = null!;
        public string? Instgrame { get; set; } = null!;

        public About About { get; set; } = null!;
    }
}
