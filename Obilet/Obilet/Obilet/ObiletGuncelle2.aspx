<%@ Page Title="" Language="C#" MasterPageFile="~/ana.Master" AutoEventWireup="true" CodeBehind="ObiletGuncelle2.aspx.cs" Inherits="Obilet.ObiletGuncelle2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

            
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >

    <style type="text/css">

.txtbox {
    float:inherit;
        width:228px;
        padding:10px;
        height:18px;
        border:1px solid #ccc;
    
    color:#555; 
    background-color:#fff;
}
.btn{

   float:left;
   margin-left:170px;
        width:100px;
        height:40px;
        line-height:40px;
        text-align:center;
        color:#0099CC;
        background-color:#ccc;
        cursor:pointer;
        margin-top:10px;
}
.btn:hover{

   
        color:#fff;
        background-color:#0099CC;
        
}     
 
.container1 {
width:660px;
margin:0 auto;
padding:0;
}http://localhost:51498/images/stsbilet.png
.folio_block {
position:absolute;
left:50%;
top:50%;
margin:-140px 0 0 -395px;
}
.main_view {
float:left;
position:relative;
}
.window {
-moz-box-shadow:0 0 5px #303030;
-webkit-box-shadow:0 0 5px #303030;
box-shadow:0 0 5px #303030;
border:1px solid #000;
height:240px;
width:660px;
margin-top:15px;
overflow:hidden;
position:relative;
}
.image_reel {
position:absolute;
top:0;
left:0;
}
.image_reel img {
float:left;
}
.paging_btrix {
position:absolute;
bottom:10px;
right:-7px;
width:250px;
height:60px;
z-index:100;
text-align:center;
line-height:40px;
background:url(http://4.bp.blogspot.com/_ELUIRQESuk4/TFw-m2eaQlI/AAAAAAAAADg/KQbHMNM6wOQ/s320/paging.png) no-repeat;
display:none;
}
.paging_btrix a {
text-decoration:none;
color:#fff;
padding:5px;
}
.paging_btrix a.active {
font-weight:700;
background:#920000;
border:1px solid #610000;
-moz-border-radius:3px;
-khtml-border-radius:3px;
-webkit-border-radius:3px;
}

    </style>
    <title>O-BİLET</title>
    
  
    
    <body>
    
        <table class="style11">
            <tr>
                <td rowspan="10" class="style13">
                  
                    <img alt="" src="images/otbsiciust.jpg" style="width: 362px; height: 34px" />
                    <asp:CheckBox ID="CheckBox1" runat="server" />
                    <img alt="" src="images/1klkt.jpg" style="width: 51px; height: 25px" />&nbsp;
                    <asp:CheckBox ID="CheckBox2" runat="server" />
                    <img alt="" src="images/2kltk.jpg" style="width: 57px; height: 25px" />&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="CheckBox3" runat="server" />
                    <img alt="" src="images/3kltk.jpg" style="width: 58px; height: 27px" />&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="CheckBox4" runat="server" />
                    <img alt="" src="images/4kltk.jpg" style="width: 51px; height: 26px" /><br />
                    <br />
                    <asp:CheckBox ID="CheckBox5" runat="server" />
                    <img alt="" src="images/5klkt.jpg" style="width: 44px; height: 24px" />&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="CheckBox6" runat="server" />
&nbsp;
                    <img alt="" src="images/6kltk.jpg" style="width: 46px; height: 24px" />&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="CheckBox7" runat="server" />
&nbsp;<img alt="" src="images/7kltk.jpg" style="width: 46px; height: 21px" />&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="CheckBox8" runat="server" />
                    <img alt="" src="images/8kltk.jpg" style="width: 50px; height: 22px" /><br />
                    <br />
                    <asp:CheckBox ID="CheckBox9" runat="server" />
                    <img alt="" src="images/9kltk.jpg" style="width: 43px; height: 22px" />&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="CheckBox10" runat="server" />
&nbsp;<img alt="" src="images/10klkt.jpg" style="width: 45px; height: 19px" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="CheckBox11" runat="server" />
                    <img alt="" src="images/11kltk.jpg" style="width: 42px; height: 20px" />&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="CheckBox12" runat="server" />
                    <img alt="" src="images/12kltk.jpg" style="width: 47px; height: 24px" /><br />
                    <br />
                    <asp:CheckBox ID="CheckBox13" runat="server" />
                    <img alt="" src="images/13kltk.jpg" style="width: 34px; height: 22px" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="CheckBox14" runat="server" />
                    <img alt="" src="images/14kltk.jpg" style="width: 47px; height: 24px" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="CheckBox15" runat="server" />
                    <img alt="" src="images/15kltk.jpg" style="width: 46px; height: 22px" />&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="CheckBox16" runat="server" />
                    <img alt="" src="images/16kltk.jpg" style="width: 50px; height: 23px" /><br />
                    <br />
                    <asp:CheckBox ID="CheckBox17" runat="server" />
                    <img alt="" src="images/17kltk.jpg" style="width: 48px; height: 26px" />&nbsp;
                    <asp:CheckBox ID="CheckBox18" runat="server" />
                    <img alt="" src="images/18kltk.jpg" style="width: 43px; height: 22px" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="CheckBox19" runat="server" />
                    <img alt="" src="images/19kltk.jpg" style="width: 40px; height: 18px" />&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="CheckBox20" runat="server" />
                    <img alt="" src="images/20kltk.jpg" style="width: 46px; height: 22px" /><br />
                    <br />
                    <br />
                    <asp:CheckBox ID="CheckBox21" runat="server" />
                    <img alt="" src="images/21kltk.jpg" style="width: 49px; height: 24px" />
                    <asp:CheckBox ID="CheckBox22" runat="server" />
&nbsp;<img alt="" src="images/22kltk.jpg" style="width: 42px; height: 24px" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="CheckBox23" runat="server" />
                    <img alt="" src="images/23kltk.jpg" style="width: 47px; height: 22px" /><asp:CheckBox 
                        ID="CheckBox24" runat="server" />
                    <img alt="" src="images/24kltk.jpg" style="width: 48px; height: 24px" /><br />
                    <br />
                    <asp:CheckBox ID="CheckBox25" runat="server" />
                    <img alt="" src="images/25kltk.jpg" style="width: 47px; height: 24px" /><asp:CheckBox 
                        ID="CheckBox26" runat="server" />
                    <img alt="" src="images/26kltk.jpg" style="width: 44px; height: 26px" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="CheckBox27" runat="server" />
                    <img alt="" src="images/27kltk.jpg" style="width: 48px; height: 24px" />&nbsp;
                    <asp:CheckBox ID="CheckBox28" runat="server" />
                    <img alt="" src="images/28kltk.jpg" style="width: 46px; height: 23px" /><br />
                    <br />
                    <asp:CheckBox ID="CheckBox29" runat="server" />
                    <img alt="" src="images/29kltk.jpg" style="width: 45px; height: 26px" /><asp:CheckBox 
                        ID="CheckBox30" runat="server" />
                    <img alt="" src="images/30kltk.jpg" style="width: 42px; height: 21px" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="CheckBox31" runat="server" />
                    <img alt="" src="images/31kltk.jpg" style="width: 52px; height: 23px" /><asp:CheckBox ID="CheckBox32" runat="server" />
                    <img alt="" src="images/32kltk.jpg" style="width: 54px; height: 25px" /><br />
                    <br />
                    <asp:CheckBox ID="CheckBox33" runat="server" />
                    <img alt="" src="images/33kltk.jpg" style="width: 51px; height: 23px" /><asp:CheckBox 
                        ID="CheckBox34" runat="server" />
                    <img alt="" src="images/34kltk.jpg" style="width: 55px; height: 22px" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="CheckBox35" runat="server" />
                    <img alt="" src="images/35kltk.jpg" style="width: 56px; height: 23px" />
                    <asp:CheckBox ID="CheckBox36" runat="server" />
                    <img alt="" src="images/36kltk.jpg" style="width: 52px; height: 23px" /><br />
                    <img alt="" src="images/otbsicialt.jpg" style="width: 362px; height: 91px" /></td>
                <td style="text-align: left" class="style14">
                    YOLCU ADI VE SOYADI&nbsp; :&nbsp;
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="txtbox"></asp:TextBox>
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    CİNSİYET&nbsp; :&nbsp;
                    <asp:DropDownList ID="DropDownList1" runat="server"  TabIndex="1" width="228px" padding="10px" height="18px" border="1px solid #ccc">
                        <asp:ListItem>Seç</asp:ListItem>
                        <asp:ListItem>ERKEK</asp:ListItem>
                        <asp:ListItem>KADIN</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <br />
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    Lütfen aşağıya ödeme yapacağınız kredi kartınızın bilgilerini giriniz...<br />
                    <asp:ListBox ID="ListBox1" runat="server" Enabled="False" Visible="False" 
                        Width="268px"></asp:ListBox>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    </td>
            </tr>
            <tr>
                <td>
                    KART SAHİBİNİN ADI VE SOYADI :&nbsp;&nbsp; <asp:TextBox ID="TextBox2" runat="server" Width="170px" TabIndex="2" CssClass="txtbox"></asp:TextBox>
                    </td>
            </tr>
            <tr>
                <td class="style12">
                    &nbsp;KART&nbsp; NO :&nbsp; <asp:TextBox ID="TextBox3" maxlength="4" runat="server" Width="54px" TabIndex="3" CssClass="txtbox"></asp:TextBox>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp; KART ŞİFRENİZ :&nbsp; 
                    <asp:TextBox ID="TextBox4" maxlength="4" runat="server" Width="55px" 
                        TabIndex="11" TextMode="Password" CssClass="txtbox"></asp:TextBox>
                    </td>
            </tr>
            <tr>
                <td>
                   &nbsp; TOPLAM BİLET TUTARI :&nbsp;&nbsp; 25TL</td>
            </tr>
            <tr>
                <td>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" style="text-align: center" 
                        Text="ONAYLA" Width="86px" TabIndex="13" onclick="Button1_Click" CssClass="btn" />
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server" BorderColor="Red" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
</body>
</>


</asp:Content>
