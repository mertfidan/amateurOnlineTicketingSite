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
    public partial class Yetkili : System.Web.UI.Page
    {
        SqlConnection baglanti = new SqlConnection("Server=DESKTOP-G95B3IK\\SQLEXPRESS; Database=obilet; Integrated Security=SSPI; User ID=\\username; Password=Password");
        protected void Page_Load(object sender, EventArgs e)
        {
            Label3.Visible = false;
            TextBox4.Visible = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (TextBox5.Text == "admin" && TextBox6.Text == "1234")
            {
                Label3.Visible = true;
                TextBox4.Visible = true;
                Button2.Visible = true;
                GridView2.Visible = true;
                Button3.Visible = true;
                SqlCommand comm1 = new SqlCommand("SELECT id AS BiletNo, yolcuadi AS Yolcu_ADI, kalkvar AS KALKIS_VARIS,koltukno AS KOLTUK,kalksaat AS SAAT FROM sefer ORDER BY id DESC", baglanti);
                DataTable tabloo1 = new DataTable();
                SqlDataAdapter adp1 = new SqlDataAdapter();


                comm1.Connection = baglanti;

                baglanti.Open();

                SqlDataReader dr1 = comm1.ExecuteReader();

                GridView2.DataSource = dr1;

                GridView2.DataBind();



                baglanti.Close();


            }
            else
            {
                Response.Write("<script>alert('Yetkili adını veya şifrenizi hatalı girdiniz!')</script>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            GridView2.Visible = true;
            SqlCommand comm1 = new SqlCommand("SELECT id AS BiletNo, yolcuadi AS Yolcu_ADI, kalkvar AS KALKIS_VARIS,koltukno AS KOLTUK, kalksaat AS SAAT FROM sefer WHERE yolcuadi LIKE '%" + TextBox4.Text + "%' ORDER BY id DESC", baglanti);
            DataTable tabloo1 = new DataTable();
            SqlDataAdapter adp1 = new SqlDataAdapter();


            comm1.Connection = baglanti;

            baglanti.Open();

            SqlDataReader dr1 = comm1.ExecuteReader();

            GridView2.DataSource = dr1;

            GridView2.DataBind();
            Label3.Visible = true;
            TextBox4.Visible = true;
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow satir = GridView2.SelectedRow;
            //string a = satir.Cells[0].Text.ToString();
            //Label1.Text = Session["id"].ToString();
            string idi = Convert.ToString(GridView2.SelectedRow.Cells[1].Text);


            DataTable tablo = new DataTable();
            string sil = "DELETE from sefer where id = '" + idi + "' ";
            if (sil.ToString() == "DELETE from sefer where id = '" + idi + "' ")
            {

                SqlCommand comm2 = new SqlCommand("DELETE from sefer where id = '" + Convert.ToString(GridView2.SelectedRow.Cells[1].Text) + "'", baglanti);
                DataTable tabloo2 = new DataTable();
                SqlDataAdapter adp2 = new SqlDataAdapter();


                comm2.Connection = baglanti;

                baglanti.Open();

                SqlDataReader dr2 = comm2.ExecuteReader();

                GridView2.DataSource = dr2;

                GridView2.DataBind();

                baglanti.Close();

                SqlCommand comm1 = new SqlCommand("SELECT id AS BiletNo, yolcuadi AS Yolcu_ADI, kalkvar AS KALKIS_VARIS,koltukno AS KOLTUK, kalksaat AS SAAT FROM sefer ORDER BY id DESC", baglanti);
                DataTable tabloo1 = new DataTable();
                SqlDataAdapter adp1 = new SqlDataAdapter();


                comm1.Connection = baglanti;

                baglanti.Open();

                SqlDataReader dr1 = comm1.ExecuteReader();

                GridView2.DataSource = dr1;

                GridView2.DataBind();
                Label3.Visible = true;
                TextBox4.Visible = true;
                Button2.Visible = true;


                baglanti.Close();


            }
        }
    }
}