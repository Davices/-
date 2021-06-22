using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community.Model
{
    public class GoodsType
    {
        public int GoodsTypeId	 { get; set; }
        public string GoodsGatherName { get; set; }
        public string TypeName	 { get; set; }
        public string TypeIcon	 { get; set; }
        public int Sort		 { get; set; }
        public int Status { get; set; }
    }
}
