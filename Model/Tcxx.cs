using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Tcxx
    {
        /// <summary>
        /// 停车编号
        /// </summary>
        public int tcid { get; set; }
        /// <summary>
        /// 车位外键
        /// </summary>
        public int cwxx_bm { get; set; }
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
        public DateTime tckssj { get; set; }
        /// <summary>
        /// 停车结束时间
        /// </summary>
        public DateTime? tcjssj { get; set; }
        /// <summary>
        /// 停车费用
        /// </summary>
        public decimal tcfy { get; set; }
    }
}
