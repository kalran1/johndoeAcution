using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace johndoeAcution
{
    class PurchaseItem
    {
        int id;
        public PurchaseItem(int id)
        {
            this.id = id;
        }

        public int purchaseItem()
        {

            using (johndoeDb db = new johndoeDb())
            {
                var result = db.제품_테이블.SingleOrDefault(p => p.id == this.id);
                if(result != null)
                { 
                    result.buy = !result.buy;
                    db.SaveChanges();
                    
                    if(!result.buy)
                        return 2;

                    return 1;
                }

                return 0;
            }
        }
    }
}
