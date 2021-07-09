using System;
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
    public partial class ObiletGuncelle : System.Web.UI.Page
    {
        //internal static string id = "";
        internal static string gnereden = "";
        internal static string gnereye = "";
        internal static string gyolcusayisi = "";
        internal static string gtarih = "";
        internal static string ggun = "";
        internal static string gay = "";
        internal static string gyil = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void sfrlistele_Click(object sender, EventArgs e)
        {
            gnereden = DropDownList1.SelectedItem.ToString();
            gnereye = DropDownList2.SelectedItem.ToString();
            gyolcusayisi = TextBox1.Text;
            gtarih = Calendar1.SelectedDate.ToLongDateString();
            ggun = Calendar1.SelectedDate.Day.ToString();
            gay = Calendar1.SelectedDate.Month.ToString();
            gyil = Calendar1.SelectedDate.Year.ToString();
            if (DropDownList1.SelectedItem.ToString() == "Bir şehir seçin...")
            {
                Response.Write("<script>alert('Lütfen nereden gideceğinizi seçin...')</script>");
                return;
            }
            if (DropDownList2.SelectedItem.ToString() == "Bir şehir seçin...")
            {

                Response.Write("<script>alert('Lütfen nereye gideceğiniz şehri seçin...')</script>");
                return;
            }



            if (Calendar1.SelectedDate.ToShortDateString() == "01.01.0001")
            {
                Response.Write("<script>alert('Bir tarih seçin ...')</script>");
                return;
            }
            if (Calendar1.SelectedDate.ToShortDateString() != DateTime.Now.ToShortDateString() &&
                Calendar1.SelectedDate.ToShortDateString() != DateTime.Now.AddDays(1).ToShortDateString())
            {

                Label1.Text = "SEFER BULUNAMADI!";
                return;
            }


            Label1.Text = gnereden + "-" + gnereye + " Yolcu sayısı : " + gyolcusayisi + " Tarih : " + gtarih;
            Response.Redirect("ObiletGuncelle1.aspx");
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
