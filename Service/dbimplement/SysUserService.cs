using Dapper;
using Microsoft.Extensions.Options;
using Model;
using Service.dbinterface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.dbimplement
{
    public class SysUserService : ISysUserService
    {
        public readonly string LinkSQL; //定义全局连接字符串

        public SysUserService(IOptions<ConnStr> conection)  //重写构造函数，包含注入的appsettings.json文件的数据库配置信息
        {
            LinkSQL = conection.Value.Connecting;
        }

        public async Task<int> AddSysUser(SysUser user)
        {
            using (var db = new SqlConnection(LinkSQL))
            {
                var sql = $@"INSERT INTO [dbo].[yhxx]([yhzh], [yhxm], [yhmm], [yhlb]) VALUES (@yhzh, @yhxm, @yhmm, @yhlb);";
                var result = await db.ExecuteAsync(sql, user);
                return result;
            }
        }

        public async Task<int> DelSysUser(string id)
        {
            using (var db = new SqlConnection(LinkSQL))
            {
                var sql = $@"delete from [yhxx] where yhzh=@id";
                var result = await db.ExecuteAsync(sql,new { id});
                return result;
            }
        }

        public async Task<SysUser> GetTheUser(string accout)
        {
            using (var db = new SqlConnection(LinkSQL))
            {
                var result = await db.QuerySingleOrDefaultAsync<SysUser>($@" select * from yhxx where yhzh = @accout", new
                {
                    accout
                });
                return result;
            }
        }

        public async Task<List<SysUser>> GetUserList(string queryType, string queryText)
        {
            var where = new StringBuilder();
            var sql = new StringBuilder();
            if (queryType != null && queryType != "")
            {
                where.Append($" and [{queryType}] like '%{queryText}%'");
            }

            sql.Append($@"select * from yhxx where 1=1 {where}");

            using (var db = new SqlConnection(LinkSQL))
            {
                try
                {
                    using (var multi = await db.QueryMultipleAsync(sql.ToString()))
                    {
                        var datalist = multi.Read<SysUser>().ToList();
                        return datalist;
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public async Task<int> updateSysUser(SysUser user)
        {
            using (var db = new SqlConnection(LinkSQL))
            {
                var sql = $@"UPDATE [dbo].[yhxx] SET [yhxm] = @yhxm, [yhmm] = @yhmm, [yhlb] = @yhlb WHERE [yhzh] = @yhzh;";
                var result = await db.ExecuteAsync(sql, user);
                return result;
            }
        }

        public async Task<SysUser> UserLogin(string accout, string password)
        {
            using (var db = new SqlConnection(LinkSQL))
            {
                var result = await db.QuerySingleOrDefaultAsync<SysUser>($@" select * from yhxx where yhzh = @accout and yhmm = @password",new
                {
                    accout,password
                });
                return result;
            }
        }
    }
}
