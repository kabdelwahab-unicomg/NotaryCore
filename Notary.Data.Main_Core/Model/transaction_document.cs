using System;

namespace Notary.Data.Main_Core.Model
{
    public class transaction_document
    {
        public int Id { get; set; }
        public string document_description { get; set; }
        public int document_type_id { get; set; }
        public int transaction_common_data_id { get; set; }
        public Nullable<int> documentCategoryId { get; set; }

        public virtual NotaryDocuments NotaryDocuments { get; set; }
        public virtual transaction_common_data transaction_common_data { get; set; }
    }
}