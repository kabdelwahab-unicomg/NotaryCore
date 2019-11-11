namespace Notary.Data.Main_Core.Model
{
    public class NotaryDocuments
    {
        public int Id { get; set; }
        public byte[] Image_Content { get; set; }
        public string FileName { get; set; }
        public string Extension { get; set; }

        //public virtual transaction_document transaction_document { get; set; }
    }
}