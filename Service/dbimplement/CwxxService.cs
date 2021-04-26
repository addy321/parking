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
    public class CwxxService : ICwxxService
    {
        public readonly string LinkSQL; //定义全局连接字符串

        public CwxxService(IOptions<ConnStr> conection)  //重写构造函数，包含注入的appsettings.json文件的数据库配置信息
        {
            LinkSQL = conection.Value.Connecting;
        }

        public async Task<int> AddCwxx(Cwxx user)
        {
            using (var db = new SqlConnection(LinkSQL))
            {
                var sql = $@"INSERT INTO [dbo].[cwxx]( [cwmc], [mxsfy], [cwzt],[zsyh],[yxsc],[zsjg]) VALUES ( @cwmc, @mxsfy, @cwzt,@zsyh,@yxsc,@zsjg);";
                var result = await db.ExecuteAsync(sql, user);
                return result;
            }
        }

        public async Task<int> DelCwxx(int id)
        {
            using (var db = new SqlConnection(LinkSQL))
            {
                var sql = $@"delete from [cwxx] where cwbm=@id";
                var result = await db.ExecuteAsync(sql, new { id });
                return result;
            }
        }

        public async Task<List<Cwxx>> GetCwxxList(string queryType, string queryText,string loginUser)
        {
            var where = new StringBuilder();
            var sql = new StringBuilder();
            if (queryType != null && queryType != "")
            {
                where.Append($" and [{queryType}] like '%{queryText}%'");
            }

            if(loginUser != "admin")
            {
                where.Append($" and zsyh = '{loginUser}'");
            }

            sql.Append($@"select * from cwxx where 1=1 {where}");

            using (var db = new SqlConnection(LinkSQL))
            {
                try
                {
                    using (var multi = await db.QueryMultipleAsync(sql.ToString()))
                    {
                        var datalist = multi.Read<Cwxx>().ToList();
                        return datalist;
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public async Task<Cwxx> GetTheUser(string cwbm)
        {
            using (var db = new SqlConnection(LinkSQL))
            {
                var result = await db.QuerySingleOrDefaultAsync<Cwxx>($@" select * from cwxx where cwbm = @cwbm", new
                {
                    cwbm
                });
                return result;
            }
        }

        public async Task<int> updateCwxx(Cwxx user)
        {
            using (var db = new SqlConnection(LinkSQL))
            {
                var sql = $@"UPDATE [dbo].[cwxx] SET [cwmc] = @cwmc, [mxsfy] = @mxsfy, [cwzt] = @cwzt,[zsyh]=@zsyh,[yxsc]=@yxsc,[zsjg]=@zsjg WHERE [cwbm] = @cwbm;";
                var result = await db.ExecuteAsync(sql, user);
                return result;
            }
        }

        public async Task<int> updateCwxx(int cwbm, string cwzt)
        {
            using (var db = new SqlConnection(LinkSQL))
            {
                var sql = $@"UPDATE [dbo].[cwxx] SET [cwzt] = @cwzt WHERE [cwbm] = @cwbm;";
                var result = await db.ExecuteAsync(sql, new {
                    cwzt,
                    cwbm
                });
                return result;
            }
        }
    }
}
