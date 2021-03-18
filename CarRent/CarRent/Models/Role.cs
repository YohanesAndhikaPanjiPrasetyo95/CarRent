﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models
{
    [Table("tb_m_role")]
    public class Role
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
    }
}
