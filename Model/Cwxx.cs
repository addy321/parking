using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Cwxx
    {
        /// <summary>
        /// 车位主键
        /// </summary>
        public int cwbm { get; set; }
        /// <summary>
        /// 车位名称
        /// </summary>
        public string cwmc { get; set; }
        /// <summary>
        /// 车位价格
        /// </summary>
        public string mxsfy { get; set; }
        /// <summary>
        /// 车位状态
        /// </summary>
        public string cwzt { get; set; }
        /// <summary>
        /// 专属用户
        /// </summary>
        public string zsyh { get; set; }
        /// <summary>
        /// 有效时间
        /// </summary>
        public DateTime? yxsc { get; set; }
        /// <summary>
        /// 专属价格
        /// </summary>
        public decimal? zsjg { get; set; }
    }
}
