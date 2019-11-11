using System;

namespace Notary.Data.Main_Core.Model
{
    public class transaction_fp_photo
    {
        public int transaction_common_data_id { get; set; }
        public byte[] finger_print { get; set; }
        public byte[] citizen_photo { get; set; }
        public int Id { get; set; }
        public Nullable<int> citizen_transaction_common_data_id { get; set; }

        public virtual citizen_transaction_common_data citizen_transaction_common_data { get; set; }
    }
}