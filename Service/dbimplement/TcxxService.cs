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
    public class TcxxService: ITcxxService
    {
        public readonly string LinkSQL; //定义全局连接字符串

        public TcxxService(IOptions<ConnStr> conection)  //重写构造函数，包含注入的appsettings.json文件的数据库配置信息
        {
            LinkSQL = conection.Value.Connecting;
        }

        public async Task<int> AddTcxx(Tcxx user)
        {
            using (var db = new SqlConnection(LinkSQL))
            {
                var sql = $@"INSERT INTO [dbo].[tcxx]( [cwxx_bm], [clbm], [clxh], [tckssj], [tcjssj], [tcfy]) VALUES ( @cwxx_bm, @clbm, @clxh,@tckssj, @tcjssj, @tcfy);";
                var result = await db.ExecuteAsync(sql, user);
                return result;
            }
        }

        public async Task<int> DelTcxx(int id)
        {
            using (var db = new SqlConnection(LinkSQL))
            {
                var sql = $@"delete from [tcxx] where tcid=@id";
                var result = await db.ExecuteAsync(sql, new { id });
                return result;
            }
        }

        public async Task<List<TCJLModel>> GetTCJLList(string queryType, string queryText)
        {
            var where = new StringBuilder();
            var sql = new StringBuilder();
            if (queryType != null && queryType != "")
            {
                where.Append($" and {queryType} like '%{queryText}%'");
            }

            sql.Append($@"select  * FROM [dbo].cwxx a left join [tcxx] b on  b.cwxx_bm = a.cwbm and b.tcjssj is null where 1=1 and a.zsyh is null {where}");

            using (var db = new SqlConnection(LinkSQL))
            {
                try
                {
                    using (var multi = await db.QueryMultipleAsync(sql.ToString()))
                    {
                        var datalist = multi.Read<TCJLModel>().ToList();
                        return datalist;
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public async Task<List<TCJLModel>> GetTcxxList(string queryType, string queryText)
        {
            var where = new StringBuilder();
            var sql = new StringBuilder();
            if (queryType != null && queryType != "")
            {
                where.Append($" and {queryType} like '%{queryText}%'");
            }
            sql.Append($@" select * from [tcxx] a left join cwxx b on a.cwxx_bm = b.cwbm where 1=1 {where}");

            using (var db = new SqlConnection(LinkSQL))
            {
                try
                {
                    using (var multi = await db.QueryMultipleAsync(sql.ToString()))
                    {
                        var datalist = multi.Read<TCJLModel>().ToList();
                        return datalist;
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public async Task<TCJLModel> GetTheTCJL(string cwbm,string tcid)
        {
            string wheretcid = "";
            if (tcid !=null & tcid != "")
            {
                wheretcid += " and b.tcid ='"+ tcid + "'";
            }
            using (var db = new SqlConnection(LinkSQL))
            {
                var sql = $@" select  * FROM [dbo].cwxx a left join [tcxx] b on  b.cwxx_bm = a.cwbm and b.tcjssj is null  where a.cwbm=@cwbm {wheretcid}";
                var result = await db.QuerySingleOrDefaultAsync<TCJLModel>(sql, new
                {
                    cwbm
                });
                return result;
            }
        }

        public async Task<List<TCJLModel>> GetZSCWList(string queryType, string queryText,string userzh)
        {
            var where = new StringBuilder();
            var sql = new StringBuilder();
            if (queryType != null && queryType != "")
            {
                where.Append($" and {queryType} like '%{queryText}%'");
            }

            if (userzh.Equals("admin"))
            {
                where.Append(" and a.zsyh is not null");
            }
            else
            {
                where.Append(" and a.zsyh =@userzh");
            }

            sql.Append($@"select  * FROM [dbo].cwxx a left join [tcxx] b on  b.cwxx_bm = a.cwbm and b.tcjssj is null where 1=1  {where}");

            using (var db = new SqlConnection(LinkSQL))
            {
                try
                {
                    using (var multi = await db.QueryMultipleAsync(sql.ToString(),new { userzh }))
                    {
                        var datalist = multi.Read<TCJLModel>().ToList();
                        return datalist;
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public async Task<int> UpdateTcxx(int tcxxId, decimal fy)
        {
            using (var db = new SqlConnection(LinkSQL))
            {
                var sql = $@"UPDATE [dbo].[tcxx] SET [tcjssj] = '{DateTime.Now}', [tcfy] =@fy  WHERE [tcid] = @tcxxId;";
                var result = await db.ExecuteAsync(sql,new
                {
                    fy,
                    tcxxId
                });
                return result;
            }
        }
    }
}
