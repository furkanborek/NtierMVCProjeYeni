﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model.Entities
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }

        //Relational Properties

    }
}
