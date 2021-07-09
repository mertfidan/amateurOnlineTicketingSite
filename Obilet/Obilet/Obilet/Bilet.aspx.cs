using System;
using System.Drawing.Printing;
using System.Drawing;
using System.IO;

using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace Obilet
{
    public partial class Bilet : System.Web.UI.Page
    {
        //private static StreamReader dosyaAkimi;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Obilet2.yolcuadi;
            Label2.Text = Obilet.tarih + " " + Obilet1.saat;
            Label3.Text = Obilet2.kalkvar;
            Label4.Text = Obilet2.kalkvar.Substring(0, 1) + Obilet1.saat.Substring(0, 2) + Obilet2.kalkvar[Obilet2.kalkvar.Length - 1] + Obilet.tarih.Substring(0, 2) + Obilet2.kalkvar.Substring(3, 1) + Obilet2.kalkvar[Obilet2.kalkvar.Length - 2];
            Label5.Text = Obilet2.koltukno;
            Label6.Text = Obilet2.cinsiyet;


        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {




        }
    }
}
