using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Community.Model;

namespace Community.IRepository
{
    public interface IShopRepository
    {
        /// <summary>
        /// 门店类型
        /// </summary>
        /// <returns></returns>
        List<ShopType> ShopType();

        /// <summary>
        /// 门店管理
        /// </summary>
        /// <returns></returns>
        List<Shop> GetShop();

        /// <summary>
        /// 删除门店信息
        /// </summary>
        /// <param name="shopid"></param>
        /// <returns></returns>
        int ShopDel(int shopid);

        /// <summary>
        /// 门店添加
        /// </summary>
        /// <returns></returns>
        int ShopAdd(Shop shop); 

        /// <summary>
        /// 门店商品
        /// </summary>
        /// <returns></returns>
        List<ShopGoods> GetShopGoods(string goodsname="");

        /// <summary>
        /// 门店商品属性
        /// </summary>
        /// <returns></returns>
        List<ShopGoodsProperty> GetProperties();

        /// <summary>
        /// 提现
        /// </summary>
        /// <returns></returns>
        List<Withdraw> GetWithdraw();

    }
}
