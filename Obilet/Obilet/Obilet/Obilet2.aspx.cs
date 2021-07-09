using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;


namespace Obilet
{
    public partial class Obilet2 : System.Web.UI.Page
    {
        internal static string yolcuadi = "";
        internal static string cinsiyet = "";
        internal static string koltukno = "";
        internal static string kartsahibi = "";
        internal static string kartno = "";
        internal static string kartsifre = "";
        internal static string kalkvar = "";
        SqlConnection baglanti = new SqlConnection("Server=DESKTOP-G95B3IK\\SQLEXPRESS; Database=obilet; Integrated Security=SSPI; User ID=DESKTOP-G95B3IK\\username; Password=Password");
        //OleDbConnection baglanti=new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=obilet.accdb");
        protected void Page_Load(object sender, EventArgs e)
        {
            CheckBox1.AutoPostBack = true;
            CheckBox2.AutoPostBack = true;
            CheckBox3.AutoPostBack = true;
            CheckBox4.AutoPostBack = true;
            CheckBox5.AutoPostBack = true;
            CheckBox6.AutoPostBack = true;
            CheckBox7.AutoPostBack = true;
            CheckBox8.AutoPostBack = true;
            CheckBox9.AutoPostBack = true;
            CheckBox10.AutoPostBack = true;
            CheckBox11.AutoPostBack = true;
            CheckBox12.AutoPostBack = true;
            CheckBox13.AutoPostBack = true;
            CheckBox14.AutoPostBack = true;
            CheckBox15.AutoPostBack = true;
            CheckBox16.AutoPostBack = true;
            CheckBox17.AutoPostBack = true;
            CheckBox18.AutoPostBack = true;
            CheckBox19.AutoPostBack = true;
            CheckBox20.AutoPostBack = true;
            CheckBox21.AutoPostBack = true;
            CheckBox22.AutoPostBack = true;
            CheckBox23.AutoPostBack = true;
            CheckBox24.AutoPostBack = true;
            CheckBox25.AutoPostBack = true;
            CheckBox26.AutoPostBack = true;
            CheckBox27.AutoPostBack = true;
            CheckBox28.AutoPostBack = true;
            CheckBox29.AutoPostBack = true;
            CheckBox30.AutoPostBack = true;
            CheckBox31.AutoPostBack = true;
            CheckBox32.AutoPostBack = true;
            CheckBox33.AutoPostBack = true;
            CheckBox34.AutoPostBack = true;
            CheckBox35.AutoPostBack = true;
            CheckBox36.AutoPostBack = true;
            ///////////////////////////////////////////////////////////////
            baglanti.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = baglanti;
            string bak = "Select koltukno from sefer WHERE kalkvar = '" + Obilet.nereden + "_" + Obilet.nereye + "' AND kalksaat='" + Obilet1.saat + "' AND kalktar='" + Obilet.tarih + "'";
            command.CommandText = bak;
            SqlDataReader verioku;
            verioku = command.ExecuteReader();

            while (verioku.Read())
            {
                ListBox1.Items.Add(verioku.GetValue(0).ToString());


            }
            for (int i = 0; i < ListBox1.Items.Count; i++)
            {
                if (CheckBox1.ID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox1.Enabled = false;

                }

                if (CheckBox2.ID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox2.Enabled = false;

                }
                if (CheckBox3.ID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox3.Enabled = false;

                }
                if (CheckBox4.ID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox4.Enabled = false;

                }

                if (CheckBox5.ID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox5.Enabled = false;

                }
                if (CheckBox6.ID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox6.Enabled = false;

                }
                if (CheckBox7.ID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox7.Enabled = false;

                }

                if (CheckBox8.ID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox8.Enabled = false;

                }
                if (CheckBox9.ID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox9.Enabled = false;

                }
                if (CheckBox10.ID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox10.Enabled = false;

                }

                if (CheckBox11.ID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox11.Enabled = false;

                }
                if (CheckBox12.ID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox12.Enabled = false;

                }
                if (CheckBox13.ID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox13.Enabled = false;

                }

                if (CheckBox14.ID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox14.Enabled = false;

                }
                if (CheckBox15.ID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox15.Enabled = false;

                }
                if (CheckBox16.ID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox16.Enabled = false;

                }
                if (CheckBox17.ID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox17.Enabled = false;

                }
                if (CheckBox18.ID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox18.Enabled = false;

                }
                if (CheckBox19.ID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox19.Enabled = false;

                }
                if (CheckBox20.ID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox20.Enabled = false;

                }
                if (CheckBox21.ID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox21.Enabled = false;

                }
                if (CheckBox22.ID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox22.Enabled = false;

                }
                if (CheckBox23.ID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox23.Enabled = false;

                }
                if (CheckBox24.ID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox24.Enabled = false;

                }
                if (CheckBox25.ID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox25.Enabled = false;

                }
                if (CheckBox26.ID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox26.Enabled = false;

                }
                if (CheckBox27.ID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox27.Enabled = false;

                }
                if (CheckBox28.ID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox28.Enabled = false;

                }
                if (CheckBox29.ID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox29.Enabled = false;

                }
                if (CheckBox30.ID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox30.Enabled = false;

                }
                if (CheckBox31.ID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox31.Enabled = false;

                }
                if (CheckBox32.ID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox32.Enabled = false;

                }
                if (CheckBox33.ID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox33.Enabled = false;

                }
                if (CheckBox34.ID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox34.Enabled = false;

                }
                if (CheckBox35.ID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox35.Enabled = false;

                }
                if (CheckBox36.ID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox36.Enabled = false;

                }

            }

            verioku.Close();
            baglanti.Close();





        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            yolcuadi = TextBox1.Text;
            cinsiyet = DropDownList1.SelectedItem.ToString();
            //Label1.Text = cinsiyet;
            kartsahibi = TextBox2.Text;
            kartno = TextBox3.Text;
            kartsifre = TextBox4.Text;
            kalkvar = Obilet.nereden + "_" + Obilet.nereye;

            if (CheckBox1.Checked == true)
            {
                koltukno = CheckBox1.ID.Remove(0, 8);
                CheckBox1.Checked = false;
                CheckBox1.Enabled = false;
            }
            if (CheckBox2.Checked == true)
            {
                koltukno = CheckBox2.ID.Remove(0, 8);
                CheckBox2.Checked = false;
                CheckBox2.Enabled = false;
            }
            if (CheckBox3.Checked == true)
            {
                koltukno = CheckBox3.ID.Remove(0, 8);
                CheckBox3.Checked = false;
                CheckBox3.Enabled = false;
            }
            if (CheckBox4.Checked == true)
            {
                koltukno = CheckBox4.ID.Remove(0, 8);
                CheckBox4.Checked = false;
                CheckBox4.Enabled = false;
            }
            if (CheckBox5.Checked == true)
            {
                koltukno = CheckBox5.ID.Remove(0, 8);
                CheckBox5.Checked = false;
                CheckBox5.Enabled = false;
            }
            if (CheckBox6.Checked == true)
            {
                koltukno = CheckBox6.ID.Remove(0, 8);
                CheckBox6.Checked = false;
                CheckBox6.Enabled = false;
            }
            if (CheckBox7.Checked == true)
            {
                koltukno = CheckBox7.ID.Remove(0, 8);
                CheckBox7.Checked = false;
                CheckBox7.Enabled = false;
            }
            if (CheckBox8.Checked == true)
            {
                koltukno = CheckBox8.ID.Remove(0, 8);
                CheckBox8.Checked = false;
                CheckBox8.Enabled = false;
            }
            if (CheckBox9.Checked == true)
            {
                koltukno = CheckBox9.ID.Remove(0, 8);
                CheckBox9.Checked = false;
                CheckBox9.Enabled = false;
            }
            if (CheckBox10.Checked == true)
            {
                koltukno = CheckBox10.ID.Remove(0, 8);
                CheckBox10.Checked = false;
                CheckBox10.Enabled = false;
            }
            if (CheckBox11.Checked == true)
            {
                koltukno = CheckBox11.ID.Remove(0, 8);
                CheckBox11.Checked = false;
                CheckBox11.Enabled = false;
            }
            if (CheckBox12.Checked == true)
            {
                koltukno = CheckBox12.ID.Remove(0, 8);
                CheckBox12.Checked = false;
                CheckBox12.Enabled = false;
            }
            if (CheckBox13.Checked == true)
            {
                koltukno = CheckBox13.ID.Remove(0, 8);
                CheckBox13.Checked = false;
                CheckBox13.Enabled = false;
            }
            if (CheckBox14.Checked == true)
            {
                koltukno = CheckBox14.ID.Remove(0, 8);
                CheckBox14.Checked = false;
                CheckBox14.Enabled = false;
            }
            if (CheckBox15.Checked == true)
            {
                koltukno = CheckBox15.ID.Remove(0, 8);
                CheckBox15.Checked = false;
                CheckBox15.Enabled = false;
            }
            if (CheckBox16.Checked == true)
            {
                koltukno = CheckBox16.ID.Remove(0, 8);
                CheckBox16.Checked = false;
                CheckBox16.Enabled = false;
            }
            if (CheckBox17.Checked == true)
            {
                koltukno = CheckBox17.ID.Remove(0, 8);
                CheckBox17.Checked = false;
                CheckBox17.Enabled = false;
            }
            if (CheckBox18.Checked == true)
            {
                koltukno = CheckBox18.ID.Remove(0, 8);
                CheckBox18.Checked = false;
                CheckBox18.Enabled = false;
            }
            if (CheckBox19.Checked == true)
            {
                koltukno = CheckBox19.ID.Remove(0, 8);
                CheckBox19.Checked = false;
                CheckBox19.Enabled = false;
            }
            if (CheckBox20.Checked == true)
            {
                koltukno = CheckBox20.ID.Remove(0, 8);
                CheckBox20.Checked = false;
                CheckBox20.Enabled = false;
            }
            if (CheckBox21.Checked == true)
            {
                koltukno = CheckBox21.ID.Remove(0, 8);
                CheckBox21.Checked = false;
                CheckBox21.Enabled = false;
            }
            if (CheckBox22.Checked == true)
            {
                koltukno = CheckBox22.ID.Remove(0, 8);
                CheckBox22.Checked = false;
                CheckBox22.Enabled = false;
            }
            if (CheckBox23.Checked == true)
            {
                koltukno = CheckBox23.ID.Remove(0, 8);
                CheckBox23.Checked = false;
                CheckBox23.Enabled = false;
            }
            if (CheckBox24.Checked == true)
            {
                koltukno = CheckBox24.ID.Remove(0, 8);
                CheckBox24.Checked = false;
                CheckBox24.Enabled = false;
            }
            if (CheckBox25.Checked == true)
            {
                koltukno = CheckBox25.ID.Remove(0, 8);
                CheckBox25.Checked = false;
                CheckBox25.Enabled = false;
            }
            if (CheckBox26.Checked == true)
            {
                koltukno = CheckBox26.ID.Remove(0, 8);
                CheckBox26.Checked = false;
                CheckBox26.Enabled = false;
            }
            if (CheckBox27.Checked == true)
            {
                koltukno = CheckBox27.ID.Remove(0, 8);
                CheckBox27.Checked = false;
                CheckBox27.Enabled = false;
            }
            if (CheckBox28.Checked == true)
            {
                koltukno = CheckBox28.ID.Remove(0, 8);
                CheckBox28.Checked = false;
                CheckBox28.Enabled = false;
            }
            if (CheckBox29.Checked == true)
            {
                koltukno = CheckBox29.ID.Remove(0, 8);
                CheckBox29.Checked = false;
                CheckBox29.Enabled = false;
            }
            if (CheckBox30.Checked == true)
            {
                koltukno = CheckBox30.ID.Remove(0, 8);
                CheckBox30.Checked = false;
                CheckBox30.Enabled = false;
            }
            if (CheckBox31.Checked == true)
            {
                koltukno = CheckBox31.ID.Remove(0, 8);
                CheckBox31.Checked = false;
                CheckBox31.Enabled = false;
            }
            if (CheckBox32.Checked == true)
            {
                koltukno = CheckBox32.ID.Remove(0, 8);
                CheckBox32.Checked = false;
                CheckBox32.Enabled = false;
            }
            if (CheckBox33.Checked == true)
            {
                koltukno = CheckBox33.ID.Remove(0, 8);
                CheckBox33.Checked = false;
                CheckBox33.Enabled = false;
            }
            if (CheckBox34.Checked == true)
            {
                koltukno = CheckBox34.ID.Remove(0, 8);
                CheckBox34.Checked = false;
                CheckBox34.Enabled = false;
            }
            if (CheckBox35.Checked == true)
            {
                koltukno = CheckBox35.ID.Remove(0, 8);
                CheckBox35.Checked = false;
                CheckBox35.Enabled = false;
            }
            if (CheckBox36.Checked == true)
            {
                koltukno = CheckBox36.ID.Remove(0, 8);
                CheckBox36.Checked = false;
                CheckBox36.Enabled = false;
            }
            //Label1.Text = koltukno;



            if (yolcuadi == "")
            {
                Response.Write("<script>alert('YOLCU ADI GİRİN ...')</script>");
                return;
            }
            if (cinsiyet == "")
            {
                Response.Write("<script>alert('CİNSİYETİNİZİ GİRİN...')</script>");
                return;
            }
            if (kartsifre == "")
            {
                Response.Write("<script>alert('ŞİFRENİZİ GİRİN ...')</script>");
                return;
            }
            if (kartsahibi == "")
            {
                Response.Write("<script>alert('KART SAHİBİ ADINI GİRİN ...')</script>");
                return;
            }
            if (kartno == "")
            {
                Response.Write("<script>alert('KREDİ KARTI NUMARANIZI GİRİN ...')</script>");
                return;
            }
            if (koltukno == "")
            {
                Response.Write("<script>alert('BİR KOLTUK SEÇİN ...')</script>");
                return;
            }
            if (int.Parse(Obilet2.kartno) < 6666 || int.Parse(Obilet2.kartno) > 7777)
            {
                Response.Redirect("Bilet.aspx");
            }



            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            baglanti.Open();
            string tablokur = "CREATE TABLE " + Obilet.nereden + "_" + Obilet.nereye + "1" + " (id int IDENTITY(1,1), yolcuadi varchar(50), cinsiyet varchar(50), yolcusayi varchar(50), kalktar varchar(50), koltukno varchar(50), kalksaat varchar(50) ,kartsahibiadi varchar(50), kartno varchar(4), kartsifre varchar(50))";
            string tablokur2 = "CREATE TABLE " + Obilet.nereden + "_" + Obilet.nereye + "2" + " (id int IDENTITY(1,1), yolcuadi varchar(50), cinsiyet varchar(50), yolcusayi varchar(50), kalktar varchar(50), koltukno varchar(50), kalksaat varchar(50) ,kartsahibiadi varchar(50), kartno varchar(4), kartsifre varchar(50))";
            string tablokur3 = "CREATE TABLE " + Obilet.nereden + "_" + Obilet.nereye + "3" + " (id int IDENTITY(1,1), yolcuadi varchar(50), cinsiyet varchar(50), yolcusayi varchar(50), kalktar varchar(50), koltukno varchar(50), kalksaat varchar(50) ,kartsahibiadi varchar(50), kartno varchar(4), kartsifre varchar(50))";

            SqlCommand command = new SqlCommand();

            DateTime a = new DateTime(int.Parse(Obilet.yil), int.Parse(Obilet.ay), int.Parse(Obilet.gun));
            var sqlFormattedDate = a.Date.ToString("yyyy-MM-dd");
            //DataTable tablo = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter();
            command.Connection = baglanti;
            string varmi1 = "Select Count(kalksaat) from sefer WHERE kalkvar = '" + Obilet.nereden + "_" + Obilet.nereye + "' AND kalksaat = '13:00' AND kalktar ='" + Obilet.tarih + "' ";
            string varmi2 = "Select Count(kalksaat) from sefer WHERE kalkvar = '" + Obilet.nereden + "_" + Obilet.nereye + "' AND kalksaat = '17:00' AND kalktar ='" + Obilet.tarih + "'";
            string varmi3 = "Select Count(kalksaat) from sefer WHERE kalkvar = '" + Obilet.nereden + "_" + Obilet.nereye + "' AND kalksaat = '19:00' AND kalktar ='" + Obilet.tarih + "'";
            //string bak = "Select COUNT(kalkvar) from sefer WHERE kalkvar = '"+Obilet.nereden+"_"+Obilet.nereye+"' AND kalksaat= ";
            //string varmi = "SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME=" + Obilet.nereden + "_" + Obilet.nereye + "1"+"";
            //command.CommandText = varmi;
            //adp.SelectCommand = command;
            //adp.Fill(tablo);
            //command.CommandText = varmi;

            //SqlCommand komut = new SqlCommand("SELECT @@ROWCOUNT FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME=" + Obilet.nereden + "_" + Obilet.nereye + "1" + "", baglanti);

            if (Obilet1.saat == "13:00")
            {
                command.CommandText = varmi1;
                SqlDataReader dr;
                dr = command.ExecuteReader();

                while (dr.Read())
                {
                    Label1.Text = dr.GetValue(0).ToString();
                    int tur = int.Parse(Label1.Text);
                    dr.Close();

                    if (int.Parse(Label1.Text) < 37)
                    {
                        command.CommandText = "INSERT INTO sefer (yolcuadi,kalkvar,cinsiyet,yolcusayi,koltukno,kalktar,kalksaat,kartsahibiadi,kartno,kartsifre) VALUES ('" + yolcuadi + "','" + kalkvar + "','" + cinsiyet + "','" + Obilet.yolcusayisi + "','" +koltukno + "','" + Obilet.tarih + "','" + Obilet1.saat + "','" + kartsahibi + "','" + kartno + "','" + kartsifre + "')";
                        command.ExecuteNonQuery();
                        break;

                    }
                    else
                    {

                        break;
                    }




                }


                //command.CommandText = "INSERT INTO sefer (yolcuadi,kalkvar,cinsiyet,yolcusayi,koltukno,kalktar,kalksaat,kartsahibiadi,kartno,kartsifre) VALUES ('" + yolcuadi + "','"+kalkvar+"','" + cinsiyet + "','" + Obilet.yolcusayisi + "','" + koltukno + "','" + Obilet.tarih + "','" + Obilet1.saat + "','" + kartsahibi + "','" + kartno + "','" + kartsifre + "')";
                //command.ExecuteNonQuery();


            }
            if (Obilet1.saat == "17:00")
            {

                command.CommandText = varmi2;

                SqlDataReader dr;

                dr = command.ExecuteReader();

                while (dr.Read())
                {
                    Label1.Text = dr.GetValue(0).ToString();
                    int tur = int.Parse(Label1.Text);
                    Label1.Text = "0";
                    dr.Close();

                    if (tur < 37)
                    {
                        command.CommandText = "INSERT INTO sefer (yolcuadi,kalkvar,cinsiyet,yolcusayi,koltukno,kalktar,kalksaat,kartsahibiadi,kartno,kartsifre) VALUES ('" + yolcuadi + "','" + kalkvar + "','" + cinsiyet + "','" + Obilet.yolcusayisi + "','" + koltukno + "','" + Obilet.tarih + "','" + Obilet1.saat + "','" + kartsahibi + "','" + kartno + "','" + kartsifre + "')";
                        command.ExecuteNonQuery();
                        break;

                    }
                    else
                    {

                        break;
                    }




                }


            }



            if (Obilet1.saat == "19:00")
            {
                command.CommandText = varmi3;
                SqlDataReader dr;
                dr = command.ExecuteReader();

                while (dr.Read())
                {
                    Label1.Text = dr.GetValue(0).ToString();
                    //int tur = int.Parse(Label1.Text);
                    Label1.Text = "0";
                    dr.Close();

                    if (int.Parse(Label1.Text) < 37)
                    {
                        command.CommandText = "INSERT INTO sefer (yolcuadi,kalkvar,cinsiyet,yolcusayi,koltukno,kalktar,kalksaat,kartsahibiadi,kartno,kartsifre) VALUES ('" + yolcuadi + "','" + kalkvar + "','" + cinsiyet + "','" + Obilet.yolcusayisi + "','" + koltukno + "','" + Obilet.tarih + "','" + Obilet1.saat + "','" + kartsahibi + "','" + kartno + "','" + kartsifre + "')";
                        command.ExecuteNonQuery();
                        break;

                    }
                    else
                    {

                        break;
                    }




                }
            }


            baglanti.Close();
            Response.Redirect("Bilet.aspx");
        }
    }
}
