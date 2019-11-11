using System;

namespace Notary.Data.Main_Core.Model
{
    public class transaction_additional_data_sub
    {
        public int Id { get; set; }
        public int transaction_common_data_id { get; set; }
        public string TT20_sub_machine_type { get; set; }
        public string TT20_sub_machine_specifications { get; set; }
        public string TT20_sub_machine_origin { get; set; }
        public string TT20_sub_machine_purchase { get; set; }
        public Nullable<double> TT20_sub_machine_value { get; set; }

        public virtual transaction_common_data transaction_common_data { get; set; }
    }
}