﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI_PickPoint.Dtos
{
    public class OrderCreateDto
    {
        public int status { get; set; }
        public string[] orderList { get; set; }
        public decimal cost { get; set; }
        public int deliveryNumber { get; set; }
        public string recipientPhone { get; set; }
        public string FIO { get; set; }
    }
}
