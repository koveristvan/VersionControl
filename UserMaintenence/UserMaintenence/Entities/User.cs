﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserMaintenence.Entities
{
    public class User
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public String FullName { get; set; }
       
    }
}
