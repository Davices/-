using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community.Model
{
    public class Withdraw
    {
        public int WithdrawID { get; set; }

        public int ShopId { get; set; }

        public decimal WithdrawMoney { get; set; }

        public int WithdrawTypeID { get; set; }

        public string PayeeName { get; set; }

        public string WithdrawNum { get; set; }

        public DateTime WithdrawTime { get; set; }

        public int Status { get; set; }

    }
}
