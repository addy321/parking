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
    /// 停车管理
    /// </summary>
    public class TcxxController : BaseController
    {
        private readonly ITcxxService _tcxxService;
        private readonly ICwxxService _cwxxService;

        public TcxxController(ITcxxService tcxxService, ICwxxService cwxxService)
        {
            _tcxxService = tcxxService;
            _cwxxService = cwxxService;
        }

        /// <summary>
        /// 停车管理
        /// </summary>
        /// <returns></returns>
        public IActionResult TcxxPlaceV()
        {
            return View();
        }

        /// <summary>
        /// 停车记录
        /// </summary>
        /// <returns></returns>
        public IActionResult TcxxList()
        {
            return View();
        }

        /// <summary>
        /// 停车记录
        /// </summary>
        /// <returns></returns>
        public IActionResult ZscwList()
        {
            return View();
        }

        /// <summary>
        /// 停车记录
        /// </summary>
        /// <returns></returns>
        public async Task<JsonResult> TcList(string queryType, string queryText)
        {
            var dataList = await _tcxxService.GetTcxxList(queryType, queryText);
            return Json(dataList);
        }

        /// <summary>
        /// 专属车位列表
        /// </summary>
        /// <param name="queryType">查询字段</param>
        /// <param name="queryText">值</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<JsonResult> GetZSCWList(string queryType, string queryText)
        {
            var userName =  GetSession();
            if(userName == null || userName =="")
            {
                return Json(new { res="登录超时" });
            }

            var result = await _tcxxService.GetZSCWList(queryType, queryText, userName);
         
            return Json(result);
        }

        /// <summary>
        /// 停车页面
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> TcV(string cwbm,string tcid)
        {
            TCJLModel data = new TCJLModel();
            if (cwbm != null && cwbm != "")
            {
                data = await _tcxxService.GetTheTCJL(cwbm,tcid);
                if(data.tckssj != null)
                {
                    TimeSpan timeSpan = (TimeSpan)(data.tckssj - DateTime.Now);
                    var fz = (decimal)timeSpan.TotalMinutes;
                    decimal mxsfy = decimal.Parse(data.mxsfy);
                    var fy = mxsfy / 60 * fz;
                    data.tcfy = Math.Round(fy, 2);
                }
            }
            if(data.zsyh != null && data.zsyh != "")
            {
                data.tcfy = 0;
            }
            return View(data);
        }

        /// <summary>
        /// 查询列表
        /// </summary>
        /// <param name="queryType">查询字段</param>
        /// <param name="queryText">值</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<JsonResult> GetTCJLList(string queryType, string queryText)
        {
            var result = await _tcxxService.GetTCJLList(queryType, queryText);
            result.ForEach(x => {
                if(x.tcjssj == null && x.tckssj!=null)
                {
                    TimeSpan timeSpan = (TimeSpan)(x.tckssj - DateTime.Now);
                    var fz = (decimal)timeSpan.TotalMinutes;
                    decimal mxsfy = decimal.Parse(x.mxsfy);
                    var fy = mxsfy / 60 * fz;
                    x.tcfy = Math.Round(fy,2);
                }
            });
            return Json(result);
        }
        /// <summary>
        /// 新增停车
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<JsonResult> AddTcxx(Tcxx data)
        {
            Cwxx cwxx = await _cwxxService.GetTheUser(data.cwxx_bm.ToString());
            if (cwxx.zsyh != null && cwxx.zsyh != "")
            {
                if (cwxx.yxsc < DateTime.Now)
                {
                    return Json(new { res = "该车位已到期" });
                }
            }
            data.tckssj = DateTime.Now;
            var result = await _tcxxService.AddTcxx(data);
            await _cwxxService.updateCwxx(data.cwxx_bm,"已停车");
            return Json(result);
        }

        /// <summary>
        /// 结算停车
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<JsonResult> UpdateTcxx(string cwbm, string tcid)
        {
            var data = await _tcxxService.GetTheTCJL(cwbm, tcid);

            TimeSpan timeSpan = (TimeSpan)(data.tckssj - DateTime.Now);
            var fz = (decimal)timeSpan.TotalMinutes;
            decimal mxsfy = decimal.Parse(data.mxsfy);
            var fy = mxsfy / 60 * fz;
            data.tcfy = Math.Round(fy,2);
            if (data.zsyh != null && data.zsyh != "")
            {
                data.tcfy = 0;
            }
            var result = await _tcxxService.UpdateTcxx(data.tcid, data.tcfy);
            await _cwxxService.updateCwxx(int.Parse(cwbm), "空闲");
            return Json(result);
        }
    }
}
