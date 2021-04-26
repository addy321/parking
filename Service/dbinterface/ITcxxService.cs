using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.dbinterface
{
    public interface ITcxxService
    {
        /// <summary>
        /// 查询所有停车
        /// </summary>
        /// <param name="accout"></param>
        /// <returns></returns>
        Task<List<TCJLModel>> GetTCJLList(string queryType, string queryText);

        /// <summary>
        /// 查询专属停车
        /// </summary>
        /// <param name="queryType"></param>
        /// <param name="queryText"></param>
        /// <param name="userzh">登录账号</param>
        /// <returns></returns>
        Task<List<TCJLModel>> GetZSCWList(string queryType, string queryText,string userzh);

        /// <summary>
        /// 查询停车记录
        /// </summary>
        /// <param name="cwbm"></param>
        /// <returns></returns>
        Task<TCJLModel> GetTheTCJL(string cwbm,string tcid);

        /// <summary>
        /// 删除停车
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<int> DelTcxx(int id);
        /// <summary>
        /// 添加停车
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Task<int> AddTcxx(Tcxx user);
        /// <summary>
        /// 结算停车
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Task<int> UpdateTcxx(int tcxxId, decimal fy);
        /// <summary>
        /// 查询所有的停车记录
        /// </summary>
        /// <param name="queryType"></param>
        /// <param name="queryText"></param>
        /// <returns></returns>
        Task<List<TCJLModel>> GetTcxxList(string queryType, string queryText);
    }
}
