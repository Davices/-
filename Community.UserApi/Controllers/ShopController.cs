using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Community.Model;
using Community.Repository;
using Community.IRepository;
using System.Data;
using System.Data.SqlClient;

namespace Community.UserApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        private IShopRepository _shopRepository;

        public ShopController(IShopRepository shopRepository)
        {
            _shopRepository = shopRepository;
        }


        [HttpGet]
        public IActionResult ShopType()
        {

            List<ShopType> data = _shopRepository.ShopType();
            return Ok(data);
        }

        [HttpGet]
        public IActionResult GetShop()
        {
            List<Shop> data = _shopRepository.GetShop();
            //int total = data.Count;

            //data = data.Skip((page - 1) * limit).Take(limit).ToList();

            return Ok(new
            {
                statu = 200,
                data = data,
                //count = total
            });
        }

        [HttpDelete]
        public IActionResult ShopDel(int shopid)
        {
            int result = _shopRepository.ShopDel(shopid);

            return Ok(result);
        }

        [HttpPost]
        public IActionResult ShopAdd(Shop shop)
        {
            int result = _shopRepository.ShopAdd(shop);

            return Ok(result);
        }

        [HttpGet]
        public IActionResult ShopGoods(string goodsname="")
        {
            List<ShopGoods> list = _shopRepository.GetShopGoods(goodsname);

            return Ok(new { 
            statu =200,
            data = list,
            });
        }

    }
}
