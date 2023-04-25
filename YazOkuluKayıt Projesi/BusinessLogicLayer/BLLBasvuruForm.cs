using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer0;
using EntityLayer0;

namespace BusinessLogicLayer
{
    public class BLLBasvuruForm
    {
        public static void BLLBasvuruEkle(EntityBasvuruForm e)
        {
            DALBasvuruForm.DALBasvuruEkle(e);
        }

    }
}
