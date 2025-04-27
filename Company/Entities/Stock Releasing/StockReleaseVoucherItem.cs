using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class StockReleaseVoucherItem
    {
        public StockReleaseVoucherItem()
        {
            StockReleaseVoucherItemWarehouses = new HashSet<StockReleaseVoucherItemWarehouse>();
        }
        [Key]
        public int Id { get; set; }

        public int StockReleaseVoucherId { get; set; }
        public virtual StockReleaseVoucher StockReleaseVoucher { get; set; }

        public int ItemId { get; set; }
        public virtual Item Item { get; set; }

        public int Quantity { get; set; }

        public virtual ICollection<StockReleaseVoucherItemWarehouse> StockReleaseVoucherItemWarehouses { get; set; }
    }
}
