﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WebApplication1.Entities
{
    public partial class ClientType
    {
        public ClientType()
        {
            People = new HashSet<People>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Enabled { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<People> People { get; set; }
    }
}