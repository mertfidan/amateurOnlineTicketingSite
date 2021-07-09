using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obilet
{
    public partial class BiletGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = ObiletGuncelle2.gyolcuadi;
            Label2.Text = ObiletGuncelle.gtarih + " " + ObiletGuncelle1.gsaat;
            Label3.Text = ObiletGuncelle2.gkalkvar;
            Label4.Text = ObiletGuncelle2.gkalkvar.Substring(0, 1) + ObiletGuncelle1.gsaat.Substring(0, 2) + ObiletGuncelle2.gkalkvar[ObiletGuncelle2.gkalkvar.Length - 1] + ObiletGuncelle.gtarih.Substring(0, 2) + ObiletGuncelle2.gkalkvar.Substring(3, 1) + ObiletGuncelle2.gkalkvar[ObiletGuncelle2.gkalkvar.Length - 2];
            Label5.Text = ObiletGuncelle2.gkoltukno;
            Label6.Text = ObiletGuncelle2.gcinsiyet;
            Response.Write("<script>alert('BİLETİNİZ BAŞARIYLA GÜNCELLENDİ!')</script>");
        }
    }
}