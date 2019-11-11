using System;

namespace Notary.Data.Main_Core.Model
{
    public class CitizenIdentity
    {
        public string citizen_id_number { get; set; }
        public Nullable<System.DateTime> citizen_id_date { get; set; }
        public string citizen_id_issued_from { get; set; }
        public Nullable<int> citizen_id_type_id { get; set; }
        public int Id { get; set; }
        public Nullable<int> CitizenTransactionCommonDataId { get; set; }
        public string citizen_id_record { get; set; }
        public string citizen_id_sahefa { get; set; }
        public string citizen_id_m { get; set; }
        public string citizen_id_z { get; set; }
        public string citizen_id_d { get; set; }
        public string citizen_id_form_number { get; set; }
        public string citizen_id_information_office { get; set; }
        public string citizen_bookdate { get; set; }

        public virtual citizen_transaction_common_data citizen_transaction_common_data { get; set; }
    }
}