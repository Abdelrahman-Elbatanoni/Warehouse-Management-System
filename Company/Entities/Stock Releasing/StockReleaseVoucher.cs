using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class StockReleaseVoucher
    {
        public StockReleaseVoucher()
        {
            StockReleaseVoucherItems=new HashSet<StockReleaseVoucherItem>();
        }
        [Key]
        public int Id { get; set; }
        public DateTime VoucherDate { get; set; }
      
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public ICollection<StockReleaseVoucherItem> StockReleaseVoucherItems { get; set; }
    }
}
