using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer0;
using DataAccessLayer0;

namespace BusinessLogicLayer
{
    public class BLLOgrt
    {
        public static List<EntityOgrt> BLLOgrtListesi()
        {
            return DALOgrt.DALOgrtListesi();
        }

        public static bool BLLOgrtSil(EntityOgrt e)
        {
            if(e.Ogrtid!=0)
            {
                return DALOgrt.DALOgrtSil(e);
            }

            return false;
        }

        public static bool BLLOgrGuncelle(EntityOgrt e)
        {
            if(e.Ogrtid!=null)
            {
                return BLLOgrt.BLLOgrGuncelle(e);
            }

            return false;
        }

        public static bool BLLOgrEkle(EntityOgrt e)
        {
            if(e.Ogrtid!=null)
            {
                return DALOgrt.DALOgrtEkle(e);
            }

            return false;
        }

    }
}
