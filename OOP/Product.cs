﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Product
    {
        //prop yazıp çift tab basınca oluşan şablon aşağıdaki giibdir
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitStock { get; set; }


    }
}
