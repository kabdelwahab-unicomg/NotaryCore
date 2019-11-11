using System;
using System.Collections.Generic;

namespace Notary.Data.Main_Core.Model
{
    public class citizen_transaction_common_data
    {
        public citizen_transaction_common_data()
        {
            this.CitizenIdentity = new HashSet<CitizenIdentity>();
            this.transaction_updates = new HashSet<transaction_updates>();
            this.transaction_fp_photo = new HashSet<transaction_fp_photo>();
        }

        public int Id { get; set; }
        public int transaction_common_data_id { get; set; }
        public int citizen_id { get; set; }
        public int citizen_id_type_id { get; set; }
        public string citizen_id_number { get; set; }
        public System.DateTime citizen_id_date { get; set; }
        public int citizen_role_id { get; set; }
        public int citizen_nationality_id { get; set; }
        public string citizen_id_record { get; set; }
        public string citizen_id_sahefa { get; set; }
        public Nullable<System.DateTime> citizen_id_tanzeem_date { get; set; }
        public string citizen_id_mahfaza { get; set; }
        public string citizen_address { get; set; }
        public string citizen_job { get; set; }
        public string citizen_job_adress { get; set; }
        public string citizen_job_office { get; set; }
        public string citizen_id_issued_from { get; set; }
        public string citizen_phone_number { get; set; }
        public string citizen_tamwen_number { get; set; }
        public string citizen_tamwen_center { get; set; }
        public string citizen_info_center { get; set; }
        public string citizen_housing_id_number { get; set; }
        public string citizen_nearstPoint { get; set; }
        public string MotherName { get; set; }

        public virtual citizen citizen { get; set; }        
        public virtual ICollection<CitizenIdentity> CitizenIdentity { get; set; }
        public virtual transaction_common_data transaction_common_data { get; set; }        
        public virtual ICollection<transaction_updates> transaction_updates { get; set; }        
        public virtual ICollection<transaction_fp_photo> transaction_fp_photo { get; set; }
    }
}