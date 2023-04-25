using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using EntityLayer0;

namespace YazOkuluKayıt_Projesi
{
    public partial class Dersler1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityDers> Dersler = BLLDers.BLLDersListele();
            Repeater2.DataSource = Dersler;
            Repeater2.DataBind();
        }
    }
}