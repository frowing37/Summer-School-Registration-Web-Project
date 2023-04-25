using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer0;
using DataAccessLayer0;
using BusinessLogicLayer;

namespace YazOkuluKayıt_Projesi
{
    public partial class Ogrenciler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityOgrenci> OgrenciListele = BLLOgrenci.BLLOgrenciListele();
            Repeater1.DataSource = OgrenciListele;
            Repeater1.DataBind();
        }
    }
}