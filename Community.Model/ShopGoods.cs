using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community.Model
{
    public class ShopGoods
    {
        public int ShopGoodsId { get; set; }

        public string GoodsImg { get; set; }

        public string GoodsName { get; set; }

        public decimal Price { get; set; }

        public int Inventory { get; set; }

        public int SaleVolume { get; set; }

        public int PropertyId { get; set; }

        public int Status { get; set; }

        public DateTime CreateDate { get; set; }

        public string PropertyName { get; set; }

    }
}
