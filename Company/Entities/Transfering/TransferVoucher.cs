using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class TransferVoucher
    {
        public TransferVoucher()
        {
            TransferVoucherItems=new HashSet<TransferVoucherItem>();
        }
        [Key]
        public int Id { get; set; }
        public DateTime VoucherDate { get; set; }

        public int? SourceWarehouseId { get; set; }
        public virtual WareHouse? SourceWarehouse { get; set; }

        public int? TargetWarehouseId { get; set; }
        public virtual WareHouse? TargetWarehouse { get; set; }

        public virtual ICollection<TransferVoucherItem> TransferVoucherItems { get; set; }

    }
}
