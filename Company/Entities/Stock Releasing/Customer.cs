using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class Customer
    {
        public Customer()
        {
            StockReleaseVouchers = new HashSet<StockReleaseVoucher>();
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public virtual ICollection<StockReleaseVoucher> StockReleaseVouchers { get; set; }

    }
}
