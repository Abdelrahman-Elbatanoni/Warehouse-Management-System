using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company
{
    public class WareHouse
    {
        public WareHouse() 
        {
            WarehouseItems = new HashSet<WarehouseItem>();
            SupplyVoucherItemWarehouses = new HashSet<SupplyVoucherItemWarehouse>();
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }

        public int? SecretaryId { get; set; }
        public virtual Secretary Secretary { get; set; }

        public virtual ICollection<WarehouseItem> WarehouseItems { get; set; }
        public virtual ICollection<SupplyVoucherItemWarehouse> SupplyVoucherItemWarehouses { get; set; }
    }
}
