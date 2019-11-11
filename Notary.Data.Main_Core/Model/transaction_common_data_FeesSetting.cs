using System;

namespace Notary.Data.Main_Core.Model
{
    public class transaction_common_data_FeesSetting
    {
        public int Id { get; set; }
        public int TransactionId { get; set; }
        public int FeesTypeId { get; set; }
        public Nullable<decimal> PercentageForOriginal { get; set; }
        public Nullable<decimal> PercentageForCopies { get; set; }
        public Nullable<decimal> MinValueForOriginal { get; set; }
        public Nullable<decimal> MaxValueForOriginal { get; set; }
        public Nullable<decimal> MinValueForCopies { get; set; }
        public Nullable<decimal> MaxValueForCopies { get; set; }
        public Nullable<decimal> ValueOfOriginal { get; set; }
        public Nullable<decimal> ValueOfCopies { get; set; }
        public Nullable<decimal> OriginalFinalPercentageValue { get; set; }
        public Nullable<decimal> CopiesFinalPercentageValue { get; set; }

        public virtual transaction_common_data transaction_common_data { get; set; }
    }
}