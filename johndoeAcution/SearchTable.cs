using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace johndoeAcution
{
    public class customStruct
    {
        public int id { get; set; }
        public string name { get; set; }
        public string brand { get; set; }
        public int price { get; set; }
        public string smallName { get; set; }
        public bool buy { get; set; }
    }
    class SearchTable
    {
        string keyword;
        readonly johndoeDb db = new johndoeDb();

        public SearchTable(string kw)
        {
            keyword = kw;    
        }

        public List<customStruct> SearchByName()
        {
            using(johndoeDb db = new johndoeDb())
            {
                //db.회원정보.SingleOrDefault( p => p.LoginId == )
                string tmp1 = $"SELECT 제품_테이블.id, name, brand, price, smallName, buy FROM 제품_테이블 JOIN 소분류 ON 소분류.id = smallId where name like N'%{keyword}%'";

                return db.Database.SqlQuery<customStruct>(tmp1).ToList();
            }
        }
    }
}
