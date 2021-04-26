using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class TCJLModel
    {
        /// <summary>
        /// 车位Id
        /// </summary>
        public int cwbm { get; set; }
        /// <summary>
        /// 停车编号
        /// </summary>
        public int tcid { get; set; }
        /// <summary>
        /// 车位名称
        /// </summary>
        public string cwmc { get; set; }
        /// <summary>
        /// 车位价格
        /// </summary>
        public string mxsfy { get; set; }
        /// <summary>
        /// 车位状态 0 = 空闲  1 = 已出
        /// </summary> 
        public string cwzt { get; set; }
        /// <summary>
        /// 车辆号
        /// </summary>
        public string clbm { get; set; }
        /// <summary>
        /// 车辆型号
        /// </summary>
        public string clxh { get; set; }
        /// <summary>
        /// 停车时间
        /// </summary>
        public DateTime? tckssj { get; set; }
        /// <summary>
        /// 停车结束时间
        /// </summary>
        public DateTime? tcjssj { get; set; }
        /// <summary>
        /// 停车费用
        /// </summary>
        public decimal tcfy { get; set; }
        /// <summary>
        /// 专属用户账号
        /// </summary>
        public string zsyh { get; set; }
        /// <summary>
        /// 专属价格
        /// </summary>
        public decimal? zsjg { get; set; }
    }
}
