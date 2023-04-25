using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer0;
using EntityLayer0;

namespace BusinessLogicLayer
{
    public class BLLDers
    {

        public static List<EntityDers> BLLDersListele()
        {
            return DALDers.DALDersListesi();
        }


        public static void BLLDersSil(EntityDers e,List<EntityDers> el)
        {
            DALDers.DALSeciliDersSil(e, el);
        }

        public static bool BLLDersEkle(EntityDers e)
        {
            if(e.Dersad!=null && e.Max!=null && e.Min!=null)
            {
                return DALDers.DALDersEkle(e);
            }
            return false;
        }

    }
}
