using System;

namespace Notary.Data.Main_Core.Model
{
    public class user_activity_log
    {
        public int Id { get; set; }
        public System.DateTime log_timestamp { get; set; }
        public string log_description { get; set; }
        public int user_activity_log_type_id { get; set; }
        public Nullable<int> transaction_common_data_id { get; set; }
        public int user_id { get; set; }

        public virtual transaction_common_data transaction_common_data { get; set; }        
    }
}