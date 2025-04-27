using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class SupplyVoucher
    {
        public SupplyVoucher()
        {
            SupplyVoucherItems = new HashSet<SupplyVoucherItem>();
            WarehouseItems=new HashSet<WarehouseItem>();
        }
        
        [Key]
        public int Id { get; set; }

        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }

        public DateTime VoucherDate { get; set; }

        public virtual ICollection<SupplyVoucherItem> SupplyVoucherItems { get; set; }
        public ICollection<WarehouseItem> WarehouseItems { get; set; }

    }
}
