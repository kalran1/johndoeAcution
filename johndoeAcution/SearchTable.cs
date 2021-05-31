using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace johndoeAcution
{
    class SearchTable
    {
        string keyword;
        readonly johndoeDb db = new johndoeDb();

        public SearchTable(string kw)
        {
            keyword = kw;    
        }

        public List<제품_테이블> SearchByName()
        {
            using(johndoeDb db = new johndoeDb())
            {
                string qs = "SELECT name, brand, price, smallName, buy FROM 제품_테이블, 소분류 WHERE smallId = 소분류.id";
                return db.제품_테이블.SqlQuery(qs).ToList();
            }
        }
    }
}
