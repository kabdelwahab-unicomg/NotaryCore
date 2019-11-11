using Microsoft.EntityFrameworkCore;
using Notary.Data.Main_Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Notary.Data.Main_Core.DataBaseContext
{
    public class DB_NotaryMainEntities : DbContext
    {
        public DB_NotaryMainEntities(DbContextOptions<DB_NotaryMainEntities> options)
           : base(options)
        {

        }
        public virtual DbSet<transaction_common_data> transaction_common_data { get; set; }
        public virtual DbSet<citizen> citizen { get; set; }       
        public virtual DbSet<citizen_transaction_common_data> citizen_transaction_common_data { get; set; }
        public virtual DbSet<CitizenIdentity> CitizenIdentity { get; set; }        
        public virtual DbSet<external_visit_requests> external_visit_requests { get; set; }        
        public virtual DbSet<NotaryDocuments> NotaryDocuments { get; set; }        
        public virtual DbSet<transaction_additional_data> transaction_additional_data { get; set; }
        public virtual DbSet<transaction_additional_data_sub> transaction_additional_data_sub { get; set; }        
        public virtual DbSet<transaction_common_data_FeesSetting> transaction_common_data_FeesSetting { get; set; }
        public virtual DbSet<transaction_common_data_transaction_status> transaction_common_data_transaction_status { get; set; }
        public virtual DbSet<transaction_copy> transaction_copy { get; set; }
        public virtual DbSet<transaction_document> transaction_document { get; set; }
        public virtual DbSet<transaction_fp_photo> transaction_fp_photo { get; set; }                
        public virtual DbSet<transaction_updates> transaction_updates { get; set; }        
        public virtual DbSet<user_activity_log> user_activity_log { get; set; }             
    }
}
