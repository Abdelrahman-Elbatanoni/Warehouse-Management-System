using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class TransferVoucherItem
    {
        [Key]
        public int Id { get; set; }

        public int TransferVoucherId { get; set; }
        public virtual TransferVoucher TransferVoucher { get; set; }

        public int ItemId { get; set; }
        public virtual Item Item { get; set; }
        public int Quantity { get; set; }  

    }
}
