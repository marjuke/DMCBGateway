using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Messageinfo
    {
        public int Id { get; set; }
        public string MsgLanguage { get; set; }
        public string Message { get; set; }
        public DateTime ReqDate { get; set; }
        public DateTime AddDate { get; set; }
        public string SenderId { get; set; }
        public string MobileNo { get; set; }
        public int MsgStatus { get; set; }
        public string BranchCode { get; set; }
        public string ResCode { get; set; }
        public DateTime FwdDate { get; set; }
        public DateTime ResDate { get; set; }
        public string ResErrMsg { get; set; }
        public string ResRefID { get; set; }
        public string SystemID { get; set; }
        public string Event { get; set; }
        public string Note { get; set; }
    }
}
