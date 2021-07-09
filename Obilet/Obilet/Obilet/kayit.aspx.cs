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
    public partial class kayit : System.Web.UI.Page
    {
        SqlConnection Baglanti = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {

            pnlDurum.Visible = false;

        }

        protected void btnKayit_Click(object sender, EventArgs e)
        {
            if (txtkadi.Text != "" && txtsifre.Text != "")
            {


                Baglanti.ConnectionString = "Server=DESKTOP-G95B3IK\\SQLEXPRESS; Database=obilet; Integrated Security=SSPI; User ID=DESKTOP-G95B3IK\\username; Password=Password";
                string sorgu = "insert into Kullanicilar(Kadi,Sifre) Values (@kadi,@sifre)";
                SqlCommand cmd = new SqlCommand(sorgu, Baglanti);
                Baglanti.Open();

                try
                {
                    cmd.Parameters.AddWithValue("@kadi", txtkadi.Text);
                    cmd.Parameters.AddWithValue("@sifre", txtsifre.Text);
                    cmd.ExecuteNonQuery();
                    Baglanti.Close();

                   
                    pnlKayit.Visible = false;
                    pnlDurum.Visible = true;

                    Session.Add("kadi",txtkadi.Text);

                    lblDurum.Text = "Başarıyla kayıt yapılmıştır.";
                }
                catch (Exception)
                {

                    lblSonuc.Text = "Kaydınız yapılamamıştır.";
                }

            }
            else
            {
                lblSonuc.Text = "Boş alanları doldurmanız gerekiyor.";
            }

        }
    }
}