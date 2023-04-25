using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer0;
using BusinessLogicLayer;

namespace YazOkuluKayıt_Projesi
{
    public partial class DersSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EntityDers ders = new EntityDers();
            List<EntityDers> DersListesi = BLLDers.BLLDersListele();
            ders.Id = Convert.ToInt32(Request.QueryString["DersID"]);
            BLLDers.BLLDersSil(ders,DersListesi);
            Response.Redirect("Dersler.aspx");
        }
    }
}