using System;

namespace Notary.Data.Main_Core.Model
{
    public class transaction_updates
    {
        public int Id { get; set; }
        public string field_name { get; set; }
        public string required_updates { get; set; }
        public int transaction_common_data_id { get; set; }
        public System.DateTime update_date { get; set; }
        public Nullable<int> citizen_transaction_common_data_Id { get; set; }

        public virtual citizen_transaction_common_data citizen_transaction_common_data { get; set; }
    }
}