using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class SupplyVoucherItem
    {
        public SupplyVoucherItem()
        {
            SupplyVoucherItemWarehouses= new HashSet<SupplyVoucherItemWarehouse>();
        }

        [Key]
        public int Id { get; set; }

        public int SupplyVoucherId { get; set; }
        public virtual SupplyVoucher SupplyVoucher { get; set; }

        public int ItemId { get; set; }
        public virtual Item Item { get; set; }

        public int Quantity { get; set; }

        public DateTime ProductionDate { get; set; }
        public DateTime ExpiryDate { get; set; }

        public virtual ICollection<SupplyVoucherItemWarehouse> SupplyVoucherItemWarehouses { get; set; }

    }
}
