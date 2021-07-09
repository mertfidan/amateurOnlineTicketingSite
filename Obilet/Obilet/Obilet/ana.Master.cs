using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;
using System.Data;
using System.Data.OleDb;
using System.Configuration;
using System;
using System.Collections;
using System.Linq;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace Obilet
{
    public partial class ana : System.Web.UI.MasterPage
    {
        SqlConnection Baglanti = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            DuyurulariGetir();

            object kullanici = Session["kadi"];
            if (kullanici != null)
            {
                pnlGiris.Visible = false;
                pnlKullanici.Visible = true;
                lblKadi.Text = kullanici.ToString();
                
            }
            else
            {
                pnlKullanici.Visible = false;
                pnlGiris.Visible = true;
                
            }
        }

        private void DuyurulariGetir()
        {
            Baglanti.ConnectionString = "Server=DESKTOP-G95B3IK\\SQLEXPRESS; Database=obilet; Integrated Security=SSPI; User ID=DESKTOP-G95B3IK\\username; Password=Password";
            string sorgu = "select * from Duyurular order by Tarih desc";
            SqlCommand cmd = new SqlCommand(sorgu, Baglanti);
            Baglanti.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            lstDuyuru.DataSource = dr;
            lstDuyuru.DataBind();

            Baglanti.Close();
        }

        protected void btnGiris_Click(object sender, EventArgs e)
        {
            string sorgu = "Select*from Kullanicilar Where Kadi = @kadi AND Sifre=@sifre";

            SqlCommand cmd = new SqlCommand(sorgu, Baglanti);
            cmd.Parameters.AddWithValue("@kadi", txtkadi.Text);
            cmd.Parameters.AddWithValue("@sifre", txtsifre.Text);

            Baglanti.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Session.Timeout = 300;
                Session.Add("kadi",dr["Kadi"].ToString());
                Response.Redirect(Request.RawUrl);
                //Response.Redirect("kullanici.aspx");
            }
            else
            {
                lblSonuc.Text = "Kullanıcı adı veya şifre hatalı.";
            }
            
            Baglanti.Close();
            
        }

        protected void btnCikis_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect(Request.RawUrl);
        }

        protected void btnArama_Click(object sender, System.EventArgs e)
        {

        }

        protected void btnBilet_Click(object sender, System.EventArgs e)
        {
            Response.Redirect("Kullanici.aspx");
        }
    }
}