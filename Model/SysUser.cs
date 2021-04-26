using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class SysUser
    {
        /// <summary>
        /// 用户账户
        /// </summary>
        public string yhzh { get; set; }
        /// <summary>
        /// 用户姓名
        /// </summary>
        public string yhxm { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string yhmm { get; set; }
        /// <summary>
        /// 用户类别  1=管理员  2=车主
        /// </summary>
        public int yhlb { get; set; }
    }
}
