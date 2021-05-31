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
            return db.제품_테이블.Where(p => p.name.Contains(keyword)).ToList();
        }
    }
}
