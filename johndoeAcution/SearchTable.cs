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

        public List<CustomStructure.DataGridViewSt> SearchByName()
        {
            using(johndoeDb db = new johndoeDb())
            {
                string qs = 
                    $"SELECT 제품_테이블.id, name, brand, price, smallName, buy " +
                    $"FROM 제품_테이블 JOIN 소분류 ON 소분류.id = smallId " +
                    $"WHERE name like N'%{keyword}%'";

                return db.Database.SqlQuery<CustomStructure.DataGridViewSt>(qs).ToList();
            }
        }
    }
}
