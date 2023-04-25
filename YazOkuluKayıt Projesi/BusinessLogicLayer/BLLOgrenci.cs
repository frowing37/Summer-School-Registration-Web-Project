using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer0;
using DataAccessLayer0;

namespace BusinessLogicLayer
{
    public class BLLOgrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci p)
        {
            if(p.Ad!=null && p.Soyad!=null && p.Numara!=null && p.Mail!=null && p.Sifre!=null && p.Fotograf!=null)
            {
                return DALOgrenci.OgrenciEkle(p);
            }

            return -1;
        }


        public static List<EntityOgrenci> BLLOgrenciListele()
        {
            return DALOgrenci.OgrenciListesi();
        }

        public static List<EntityOgrenci> BLLOgrenciDetay(int id)
        {
            return DALOgrenci.DALOgrenciDetay(id);
        }


        public static bool BLLOgrenciSil(int id)
        {
            if(id!=0)
            {
                return DALOgrenci.DALOgrenciSil(id);
            }

            return false;
        }

        public static void BLLOgrenciGuncelle(EntityOgrenci a,int id)
        {
            if(a.Ad!=null && a.Ad!="" && a.Soyad != null && a.Soyad != "" && a.Numara != null && a.Numara != "" && a.Mail != null && a.Mail != "" && a.Sifre != null && a.Sifre != "")
            {
                DALOgrenci.DALOgrenciGüncelle(a, id);
            }
        }

    }
}
