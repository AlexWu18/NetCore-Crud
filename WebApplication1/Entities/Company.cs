﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WebApplication1.Entities
{
    public partial class Company
    {
        public Company()
        {
            People = new HashSet<People>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Boss { get; set; }
        public string PrimaryPhone { get; set; }
        public string SecondaryPhone { get; set; }
        public string Fax { get; set; }
        public string EmailAddress { get; set; }
        public string WebSite { get; set; }
        public bool Enabled { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<People> People { get; set; }
    }
}