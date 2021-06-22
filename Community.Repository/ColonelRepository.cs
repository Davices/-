using Community.IRepository;
using System;
using System.Collections.Generic;
using Community.Common;
using Community.Model;
using System.Text;

namespace Community.Repository
{
    public class ColonelRepository : IColonelRepository
    {
        DbFactory dbFactory = new DbFactory();
        # region///获取团长数据、查询
        /// <summary>
        /// 获取团长数据、查询
        /// </summary>
        /// <param name="colonelName"></param>
        /// <returns></returns>
        public List<Colonel> GetColonelDataBySearch(string colonelName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ColonelId,Img,ColonelName,ColonelPhone,City,PickUpID,Colonelfee,CheckName,ApplyDate,CheckDate,CheckStatu from Colonel where 1=1");
            if (!string.IsNullOrEmpty(colonelName))
            {
                strSql.Append(" and ColonelName like CONCAT('%',@ColonelName,'%')");
            }
            var data= dbFactory.DbHelper().Query<Colonel>(strSql.ToString(), new { @ColonelName = colonelName });
            return data;
        }
        #endregion//
    }
}
