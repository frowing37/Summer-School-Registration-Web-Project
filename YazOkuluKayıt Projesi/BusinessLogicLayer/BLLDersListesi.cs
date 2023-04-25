using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer0;
using DataAccessLayer0;

namespace BusinessLogicLayer
{
    public class BLLDersListesi
    {
        public static List<EntityOgrt> BLLOgrtListesi()
        {
            return DALOgrt.DALOgrtListesi();
        }
    }
}
