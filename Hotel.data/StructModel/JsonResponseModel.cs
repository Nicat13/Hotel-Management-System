using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.data.StructModel
{
   public class JsonResponseModel
    {
        public int statusCode { get; set; }
        public string message { get; set; }
        public object obj { get; set; }
    }
}
