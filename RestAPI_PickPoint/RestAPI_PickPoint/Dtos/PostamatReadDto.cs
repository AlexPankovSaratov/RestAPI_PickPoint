using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI_PickPoint.Dtos
{
    public class PostamatReadDto
    {
        public string number { get; set; }
        public string address { get; set; }
        public bool status { get; set; }
    }
}
