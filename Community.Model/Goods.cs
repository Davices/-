using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community.Model
{
    public class Goods
    {
        public int GoodsId			     { get; set; }
        public string GoodsNo			 { get; set; }
        public string GoodsName		  { get; set; }
        public decimal MarketPrice		 { get; set; }
        public decimal GoodsPrice		 { get; set; }
        public int GoodsStock		 { get; set; }
        public int SaleNum			 { get; set; }
        public int Status			 { get; set; }
        public DateTime CreateTime		 { get; set; }
        public string GoodsDesc		 { get; set; }
        public string GoodsImg		 { get; set; }
        public int Sort			 { get; set; }
        public decimal SumPrice		 { get; set; }
        public string ImageShow		 { get; set; }
        public DateTime SaleTime		 { get; set; }
        public string SaleTimeModel { get { return SaleTime.ToString("yyyy-MM-dd hh:ss"); } }
        public string GoodsUnit		 { get; set; }
        public string Keyword			 { get; set; }
        public int GoodsTypeId		 { get; set; }
        public int FreightId		 { get; set; }
        public int EvaluateId		 { get; set; }
        public int ShopPropertyID 	 { get; set; }

    }
}
