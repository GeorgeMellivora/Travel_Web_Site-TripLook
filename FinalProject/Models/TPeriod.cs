﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FinalProject.Models
{
    public partial class TPeriod
    {
        public TPeriod()
        {
            TProduct = new HashSet<TProduct>();
        }

        public byte FId { get; set; }
        public string FDescription { get; set; }

        public virtual ICollection<TProduct> TProduct { get; set; }
    }
}