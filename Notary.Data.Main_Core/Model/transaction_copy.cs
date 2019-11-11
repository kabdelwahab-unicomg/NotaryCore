using System;

namespace Notary.Data.Main_Core.Model
{
    public class transaction_copy
    {
        public int Id { get; set; }
        public int transaction_common_data_id { get; set; }
        public byte[] scanned_copy { get; set; }
        public string scanned_description { get; set; }
        public Nullable<int> CopyTypeID { get; set; }

        public virtual transaction_common_data transaction_common_data { get; set; }
    }
}