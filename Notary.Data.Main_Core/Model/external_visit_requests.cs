using System;
using System.Collections.Generic;

namespace Notary.Data.Main_Core.Model
{
    public class external_visit_requests
    {
        public external_visit_requests()
        {
            this.transaction_common_data = new HashSet<transaction_common_data>();
        }

        public int id { get; set; }
        public string request_ticket_number { get; set; }
        public Nullable<System.DateTime> request_date_time { get; set; }
        public string requestor_name { get; set; }
        public string notes { get; set; }
        public string address { get; set; }
        public Nullable<bool> request_decision { get; set; }
        public int office_id { get; set; }
        public int user_id { get; set; }
        public int transaction_type_id { get; set; }
        public int justicewriter_id { get; set; }
        
        public virtual ICollection<transaction_common_data> transaction_common_data { get; set; }
    }
}