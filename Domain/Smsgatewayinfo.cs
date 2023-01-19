using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Smsgatewayinfo
    {
        public int Id { get; set; }
        public string api_token { get; set; }
        public string sid { get; set;}
        public string csms_id { get; set; }
    }
}
