using System;
using System.Collections.Generic;
using System.Text;

namespace Notary.Data.Main_Core.Model
{
    public class transaction_common_data
    {
        public transaction_common_data()
        {
            this.citizen_transaction_common_data = new HashSet<citizen_transaction_common_data>();
            this.transaction_additional_data = new HashSet<transaction_additional_data>();
            this.transaction_additional_data_sub = new HashSet<transaction_additional_data_sub>();
            this.transaction_common_data_transaction_status = new HashSet<transaction_common_data_transaction_status>();
            this.transaction_document = new HashSet<transaction_document>();
            this.user_activity_log = new HashSet<user_activity_log>();
            this.transaction_common_data_FeesSetting = new HashSet<transaction_common_data_FeesSetting>();
            this.transaction_copy = new HashSet<transaction_copy>();
        }

        public int Id { get; set; }
        public string tr_ticket_number { get; set; }
        public Nullable<int> tr_public_number { get; set; }
        public Nullable<int> tr_record_number { get; set; }
        public System.DateTime tr_official_date { get; set; }
        public int tr_copy_count { get; set; }
        public Nullable<decimal> tr_paid_fees { get; set; }
        public string tr_receipt_number { get; set; }
        public Nullable<System.DateTime> tr_receipt_date { get; set; }
        public bool tr_is_internal { get; set; }
        public int transaction_type_id { get; set; }
        public int office_id { get; set; }
        public Nullable<int> external_visit_requests_id { get; set; }
        public Nullable<int> final_status { get; set; }
        public Nullable<double> tr_basic_paid_fees { get; set; }
        public Nullable<bool> IsUsed { get; set; }
        public Nullable<int> LastWorkingUserId { get; set; }
        public string TransactionNo { get; set; }
        public Nullable<decimal> tr_total_original_fees { get; set; }
        public Nullable<decimal> tr_total_addtional_fees { get; set; }
        public Nullable<decimal> tr_value { get; set; }
        public Nullable<bool> HasValue { get; set; }
        public Nullable<bool> IsExemptable { get; set; }
        public int RefrenceId { get; set; }
        public string transaction_Content { get; set; }
        public string transaction_Content_Sub1 { get; set; }
        public string transaction_Content_Sub2 { get; set; }
        
        public virtual ICollection<citizen_transaction_common_data> citizen_transaction_common_data { get; set; }
        public virtual external_visit_requests external_visit_requests { get; set; }        
        public virtual ICollection<transaction_additional_data> transaction_additional_data { get; set; }        
        public virtual ICollection<transaction_additional_data_sub> transaction_additional_data_sub { get; set; }        
        public virtual ICollection<transaction_common_data_transaction_status> transaction_common_data_transaction_status { get; set; }        
        public virtual ICollection<transaction_document> transaction_document { get; set; }        
        public virtual ICollection<user_activity_log> user_activity_log { get; set; }        
        public virtual ICollection<transaction_common_data_FeesSetting> transaction_common_data_FeesSetting { get; set; }       
        public virtual ICollection<transaction_copy> transaction_copy { get; set; }
    }
}
