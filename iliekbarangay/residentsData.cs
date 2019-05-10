using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iliekbarangay
{
    public class residentsData
    {
        public string res_id { get; set; }
        public byte res_fingerprint { get; set; }
        public string res_fname { get; set; }
        public string res_mname { get; set; }
        public string res_lname { get; set; }
        public string res_cnum { get; set; }
        public string dob { get; set; }
        public string age { get; set; }
        public byte image { get; set; }
    }
}
