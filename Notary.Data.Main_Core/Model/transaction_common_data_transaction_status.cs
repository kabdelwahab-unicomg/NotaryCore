using System;

namespace Notary.Data.Main_Core.Model
{
    public class transaction_common_data_transaction_status
    {
        public int Id { get; set; }
        public int transaction_common_data_id { get; set; }
        public int transaction_status_id { get; set; }
        public System.DateTime start_timestamp { get; set; }
        public Nullable<System.DateTime> end_timestamp { get; set; }
        public int user_id { get; set; }
        public bool isCurrent { get; set; }
        public string RejectionReason { get; set; }
        public string Remarks { get; set; }

        public virtual transaction_common_data transaction_common_data { get; set; }
    }
}