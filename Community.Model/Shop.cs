using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community.Model
{
    public class Shop
    {
        public int ShopId { get; set; }

        public string ShopAccount { get; set; }

        public string ShopPassword { get; set; }

        public int ShopTypeId { get; set; }

        public string ShopName { get; set; }

        public string ShopManager { get; set; }

        public string ManagerPhone { get; set; }

        public string ShopImg { get; set; }

        public string ShopIcon { get; set; }

        public string AuthenticationInfo { get; set; }

        public string Address { get; set; }

        public string ParticularAddress { get; set; }

        public string SelfAddress { get; set; }

        public decimal XCoordinate { get; set; }

        public decimal YCoordinate { get; set; }

        public bool IsDistribution { get; set; }

        public decimal DistributionPrice { get; set; }

        public decimal WithdrawPoint { get; set; }

        public string Explain { get; set; }

        public bool IsBusiness { get; set; }

        public int SellGoods { get; set; }

        public decimal Sale { get; set; }

        public bool ISPickUp { get; set; }

        public bool Status { get; set; }

        public bool PickStatus { get; set; }

    }
}
