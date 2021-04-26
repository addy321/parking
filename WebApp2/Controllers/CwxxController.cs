using Microsoft.AspNetCore.Mvc;
using Model;
using Service.dbinterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp2.Controllers
{
    public class CwxxController : BaseController
    {
        private readonly ICwxxService _cwxxService;
        private readonly ISysUserService _sysUserService;

        public CwxxController(ICwxxService cwxxService, ISysUserService sysUserService)
        {
            _cwxxService = cwxxService;
            _sysUserService = sysUserService;
        }
        /// <summary>
        /// 车位管理
        /// </summary>
        /// <returns></returns>
        public IActionResult CwxxPlaceV()
        {
            return View();
        }

        /// <summary>
        /// 编辑用户页面
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> ShowSave(string accout)
        {
            Cwxx user = new Cwxx();
            if (accout != null && accout != "")
            {
                user = await _cwxxService.GetTheUser(accout);
            }
            return View(user);
        }

        /// <summary>
        /// 查询车位列表
        /// </summary>
        /// <param name="queryType">查询字段</param>
        /// <param name="queryText">值</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<JsonResult> GetDataList(string queryType, string queryText)
        {
            var loginUser = GetSession();
            if(loginUser == null || loginUser == "")
            {
                return Json(new { res = "登录超时" });
            }
            var result = await _cwxxService.GetCwxxList(queryType, queryText, loginUser);
            return Json(result);
        }

        /// <summary>
        /// 新增车位
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<JsonResult> AddData(Cwxx data)
        {
            if (data.zsyh != null && data.zsyh != "")
            {
                SysUser user = await _sysUserService.GetTheUser(data.zsyh);
                if (user == null)
                {
                    return Json("该车主不存在：" + user.yhzh);
                }
                if (data.yxsc == null)
                {
                    return Json(new { res = "请选择有效时长：" + data.yxsc });
                }
                if (data.zsjg == null)
                {
                    return Json(new { res = "请填入专属价格：" + data.zsjg });
                }
            }
            var result = await _cwxxService.AddCwxx(data);
            return Json(result);
        }
        /// <summary>
        /// 删除车位
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task DelData(int id)
        {
            var result = await _cwxxService.DelCwxx(id);
            Response.Redirect("/User/CwxxPlaceV");
        }
        /// <summary>
        /// 修改车位
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<JsonResult> UpdateData(Cwxx data)
        {
            if (data.zsyh != null && data.zsyh != "")
            {
                SysUser user = await _sysUserService.GetTheUser(data.zsyh);
                if (user == null)
                {
                    return Json(new { res="该车主不存在：" + data.zsyh });
                }
                if(data.yxsc == null)
                {
                    return Json(new { res = "请选择有效时长：" + data.yxsc });
                }
                if (data.zsjg == null)
                {
                    return Json(new { res = "请填入专属价格：" + data.zsjg });
                }
            }
            var result = await _cwxxService.updateCwxx(data);
            return Json(result);
        }
    }
}
