using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.dbinterface
{
    public interface ICwxxService
    {
        /// <summary>
        /// 查询所有
        /// </summary>
        /// <param name="accout"></param>
        /// <returns></returns>
        Task<List<Cwxx>> GetCwxxList(string queryType, string queryText,string loginUser);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<int> DelCwxx(int id);
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        Task<int> AddCwxx(Cwxx data);
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        Task<int> updateCwxx(Cwxx data);
        /// <summary>
        ///  查询单个车位
        /// </summary>
        /// <param name="Id">用户账号</param>
        /// <returns></returns>
        Task<Cwxx> GetTheUser(string Id);
        /// <summary>
        /// 修改车位状态
        /// </summary>
        /// <param name="cwbm"></param>
        /// <param name="cwzt"></param>
        /// <returns></returns>
        Task<int> updateCwxx(int cwbm, string cwzt);
    }
}
