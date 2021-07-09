<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="kayit.aspx.cs" Inherits="Obilet.kayit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hızlı Kayıt Ol</title>
    <link href="style.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
    
        <div style="width:285px; margin:0 auto; margin-top:50px;" >
        <div class="sol-taraf">
            <asp:Panel ID="pnlKayit" runat="server">

                 <div class ="kayit">

                <div class="ust">
                    Hızlı Kayıt Ol !

                </div>

                <div class="alt">
                   
                    <div>  
                    <span>Kullanıcı adı</span>
                    <asp:TextBox ID="txtkadi" CssClass="textbox" runat="server" />
                    </div>
                    <div class="sifre">
                    <span>Şifre</span>
                    <asp:TextBox ID="txtsifre" CssClass="textbox" runat="server" TextMode="Password"/>
                    </div>

                    <a href="/" class="btnGiris">İptal</a>
                        <asp:Button ID="btnKayit" CssClass="btnKayit" Text="Kaydet" runat="server" OnClick="btnKayit_Click"/>
                    <asp:Label ID="lblSonuc" Text="" runat="server" />
                </div>

            </div>

            </asp:Panel>

           
            <asp:Panel ID="pnlDurum" runat="server" style="background-color:#fff; padding:10px;">

                 <asp:Label ID="lblDurum" Text="" runat="server" />
                <br />
                <a href="/">Ana Sayfaya Git</a>

            </asp:Panel>
        

            </div>
            </div>
        </div>
        </div>


    </form>
</body>
</html>
