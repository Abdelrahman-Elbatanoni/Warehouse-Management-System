using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class WarehouseItem
    {
        [Key, Column(Order = 0)]
        public int WarehouseId { get; set; }

        [Key, Column(Order = 1)]
        public int ItemId { get; set; }
        [Key, Column(Order = 2)]
        public int SupplyVoucherId { get; set; }
        public int Quantity { get; set; }

        public virtual Item Item { get; set; }
        public virtual WareHouse Warehouse { get; set; }

        public virtual SupplyVoucher SupplyVoucher { get; set; }

    }
}
