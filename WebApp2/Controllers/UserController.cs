using Microsoft.AspNetCore.Mvc;
using Model;
using Service.dbinterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp2.Controllers
{
    /// <summary>
    /// 用户管理
    /// </summary>
    public class UserController : BaseController
    {
        private readonly ISysUserService _sysUserService;

        public UserController(ISysUserService sysUserService)
        {
            _sysUserService = sysUserService;
        }
        /// <summary>
        /// 跳转登录页面
        /// </summary>
        /// <returns></returns>
        public IActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// 编辑用户页面
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> SaveUser(string accout)
        {
            SysUser user = new SysUser();
            if (accout !=null && accout != "")
            {
                user = await _sysUserService.GetTheUser(accout);
            }
            return View(user);
        }
        /// <summary>
        /// 用户管理
        /// </summary>
        /// <returns></returns>
        public IActionResult UserPlaceV()
        {
            return View();
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="account"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<JsonResult> LoginAction(string account, string password)
        {
            var result = await _sysUserService.UserLogin(account,password);
            if (result != null)
            {
                SetSession(account); // 存储会话
            }
            return Json(result);
        }

        /// <summary>
        /// 查询用户列表
        /// </summary>
        /// <param name="queryType">查询字段</param>
        /// <param name="queryText">值</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<JsonResult> GetUserList(string queryType,string queryText)
        {
            var result = await _sysUserService.GetUserList(queryType, queryText);
            return Json(result);
        }

        /// <summary>
        /// 新增用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<JsonResult> AddSysUser(SysUser user)
        {
            var result = await _sysUserService.AddSysUser(user);
            return Json(result);
        }
        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task DelSysUser(string id)
        {
            var result = await _sysUserService.DelSysUser(id);
            Response.Redirect("/User/UserPlaceV");
        }
        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<JsonResult> UpdateTeacher(SysUser user)
        {
            var result = await _sysUserService.updateSysUser(user);
            return Json(result);
        }
     
    }
}
