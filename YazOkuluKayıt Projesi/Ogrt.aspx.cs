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
    public partial class Ogrt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityOgrt> OgrtListesi = BLLOgrt.BLLOgrtListesi();
            Repeater3.DataSource = OgrtListesi;
            Repeater3.DataBind();
        }
    }
}