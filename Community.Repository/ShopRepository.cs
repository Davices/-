using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Community.Model;
using Community.IRepository;
using Community.Common;

namespace Community.Repository
{
    public class ShopRepository:IShopRepository
    {
        DbFactory factory = new DbFactory();

        /// <summary>
        /// 门店类型
        /// </summary>
        /// <returns></returns>
        public List<ShopType> ShopType()
        {
            string sql = "select ShopTypeId,PayType from ShopType";

            return factory.DbHelper().Query<ShopType>(sql);
        }

        /// <summary>
        /// 门店管理信息
        /// </summary>
        /// <returns></returns>
        public List<Shop> GetShop()
        {
            string sql = "select * from Shop a join ShopType b on a.ShopTypeId=b.ShopTypeId";

            return factory.DbHelper().Query<Shop>(sql);
        }

        /// <summary>
        /// 删除门店信息
        /// </summary>
        /// <param name="shopid"></param>
        /// <returns></returns>
        public int ShopDel(int shopid)
        {
            string sql = $"delete from Shop where ShopId=@shopid";

            return factory.DbHelper().Execute(sql,new { @shopid=shopid});
        }

        /// <summary>
        /// 门店添加
        /// </summary>
        /// <param name="shop"></param>
        /// <returns></returns>
        public int ShopAdd(Shop shop)
        {
            string sql = "insert into Shop values(@ShopTypeId,@ShopName,@ShopManager,@SellGoods,@Sale,@ISPickUp,@Status,@PickStatus)";

            return factory.DbHelper().Execute(sql,new { @ShopTypeId=shop.ShopTypeId, @ShopName=shop.ShopName, @ShopManager=shop.ShopManager, @SellGoods=shop.SellGoods,@Sale=shop.Sale,@ISPickUp=shop.ISPickUp,@Status=shop.Status,@PickStatus=shop.PickStatus });
        }

        /// <summary>
        /// 门店商品信息
        /// </summary>
        /// <returns></returns>
        public List<ShopGoods> GetShopGoods(string goodsname)
        {
            string sql = "select ShopGoods.ShopGoodsId,ShopGoods.GoodsImg,ShopGoods.GoodsName,ShopGoods.Price,ShopGoods.Inventory,ShopGoods.SaleVolume,ShopGoods.PropertyId,ShopGoods.Status,ShopGoods.CreateDate,ShopGoodsProperty.PropertyName from ShopGoods inner join ShopGoodsProperty on ShopGoods.PropertyId = ShopGoodsProperty.PropertyId where 1=1";

            if (!string.IsNullOrEmpty(goodsname))
            {
                sql += $"and ShopGoods.GoodsName like '%{@goodsname}%'";
            }

            return factory.DbHelper().Query<ShopGoods>(sql,new { @goodsname = goodsname });
        }

        public List<ShopGoodsProperty> GetProperties()
        {
            throw new NotImplementedException();
        }

        public List<Withdraw> GetWithdraw()
        {
            string sql = "";

            return factory.DbHelper().Query<Withdraw>(sql);
        }
    }
}
