﻿using CoreLayer.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.WebApplication.Entities
{
    public class Team:BaseEntity
    {
        public string? FullName { get; set; } = null!;
        public string? Title { get; set; } = null!;
        public string? FileName { get; set; } = null!;
        public string? FileType { get; set; } = null!;
        public string? Twitter { get; set; } = null!;
        public string? LinkedIn { get; set; } = null!;
        public string? Facebook { get; set; } = null!;
        public string? Instgrame { get; set; } = null!;
    }
}
