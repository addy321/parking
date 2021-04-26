using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.dbinterface
{
    public interface ISysUserService
    {
        /// <summary>
        /// 登录功能
        /// </summary>
        /// <param name="accout"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<SysUser> UserLogin(string accout, string password);

        /// <summary>
        /// 查询所有的用户
        /// </summary>
        /// <param name="accout"></param>
        /// <returns></returns>
        Task<List<SysUser>> GetUserList(string queryType,string queryText);
        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<int> DelSysUser(string id);
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Task<int> AddSysUser(SysUser user);
        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Task<int> updateSysUser(SysUser user);
        /// <summary>
        ///  查询单个用户
        /// </summary>
        /// <param name="accout">用户账号</param>
        /// <returns></returns>
        Task<SysUser> GetTheUser(string accout);

    }
}
