using System.Collections.Generic;

namespace Notary.Data.Main_Core.Model
{
    public class citizen
    {
        public citizen()
        {
            this.citizen_transaction_common_data = new HashSet<citizen_transaction_common_data>();
        }

        public int Id { get; set; }
        public string c_name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<citizen_transaction_common_data> citizen_transaction_common_data { get; set; }
    }
}