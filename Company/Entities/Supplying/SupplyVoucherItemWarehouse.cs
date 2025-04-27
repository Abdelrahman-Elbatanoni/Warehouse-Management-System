using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class SupplyVoucherItemWarehouse
    {
        [Key]
        public int Id { get; set; }

        public int SupplyVoucherItemId { get; set; }
        public virtual SupplyVoucherItem SupplyVoucherItem { get; set; }

        public int WarehouseId { get; set; }
        public virtual WareHouse Warehouse { get; set; }
        public int Quantity { get; set; }
    }
}
