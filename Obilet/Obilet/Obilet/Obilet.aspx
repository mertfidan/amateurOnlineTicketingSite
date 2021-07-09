<%@ Page Title="" Language="C#" MasterPageFile="~/ana.Master" AutoEventWireup="true" CodeBehind="Obilet.aspx.cs" Inherits="Obilet.Obilet" MaintainScrollPositionOnPostback="true" %>
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

   float:inherit:left;
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
.paging_btrix a:hover {
font-weight:700;
}
        .style13
        {
            width: 100%;
        }
        .style14
        {
            height: 161px;
            background-color: #FFFFFF;
        }
        .style15
        {
            width: 658px;
        }
        .style16
        {
            height: 161px;
            width: 658px;
        }
        .style17
        {
            width: 658px;
            font-weight: bold;
            color: #0066FF;
        }
        .style25
        {
            height: 45px;
            width: 658px;
        }
        .style26
        {
            height: 45px;
        }
        .style27
        {
            height: 43px;
            width: 658px;
        }
        .style28
        {
            height: 43px;
        }
        .auto-style1 {
            width: 215px;
        }
        .auto-style2 {
            height: 45px;
            width: 215px;
        }
        .auto-style3 {
            height: 43px;
            width: 215px;
        }
        .auto-style4 {
            height: 161px;
            width: 215px;
        }
        .auto-style5 {
            width: 26px;
        }
        .auto-style6 {
            height: 45px;
            width: 26px;
        }
        .auto-style7 {
            height: 43px;
            width: 26px;
        }
        .auto-style8 {
            height: 161px;
            width: 26px;
        }
    </style>
    <title>O-BİLET</title>
    
<body>
    
<p style="text-align: center">
    <table class="style13" cellpadding="0" cellspacing="0">
        <tr bgcolor="White">
            <td style="text-align: left" class="auto-style5">
                &nbsp;</td>
            <td style="text-align: left" class="auto-style1">
                <b>ONLİNE BİLET</b></td>
            <td>
                &nbsp;</td>

            <td>
                &nbsp;</td>

        </tr>
        <tr bgcolor="White">
            <td style="text-align: left" class="auto-style5">
                &nbsp;</td>
            <td style="text-align: left" class="auto-style1">
                        <asp:Image ID="Image3" runat="server" ImageUrl="~/images/stsbilet.png" />
                    </td>
            <td>
                &nbsp;</td>

            <td>
                &nbsp;</td>

        </tr>
       <tr>
            <td style="text-align: left" class="auto-style6" bgcolor="White">
                &nbsp;</td>
            <td style="text-align: left" class="auto-style2" bgcolor="White">
             YOLCU SAYISI :&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" MaxLength="2" CssClass="txtbox" >1</asp:TextBox>
                </td>
       </tr>
        <tr>
           
            <td style="text-align: left" class="auto-style6" bgcolor="White">
                &nbsp;</td>
           
            <td style="text-align: left" class="auto-style2" bgcolor="White">
                NEREDEN&nbsp; :&nbsp;                 
                        <asp:DropDownList ID="DropDownList1" runat="server" Width="150px" Height="30px" 
                            onselectedindexchanged="DropDownList2_SelectedIndexChanged" 
                    AutoPostBack="True">
                            <asp:ListItem>Bir şehir seçin...</asp:ListItem>
                            <asp:ListItem>ADANA</asp:ListItem>
                            <asp:ListItem>ADIYAMAN</asp:ListItem>
                            <asp:ListItem>AFYONKARAHİSAR</asp:ListItem>
                            <asp:ListItem>KONYA</asp:ListItem>
                </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                
                    </td>
                    <td style="background-color: #FFFFFF" class="style26">
                        &nbsp;</td>
                    <td style="background-color: #FFFFFF" class="style26">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="text-align: left" class="auto-style7" bgcolor="White">
                        &nbsp;</td>
                    <td style="text-align: left" class="auto-style3" bgcolor="White">
                        NEREYE&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;                 
                        <asp:DropDownList ID="DropDownList2" runat="server" Width="150px" Height="30px" 
                            onselectedindexchanged="DropDownList2_SelectedIndexChanged" 
                            AutoPostBack="True">
                            <asp:ListItem>Bir şehir seçin...</asp:ListItem>
                            <asp:ListItem>KONYA</asp:ListItem>
                            <asp:ListItem>ANKARA</asp:ListItem>
                            <asp:ListItem>İSTANBUL</asp:ListItem>
                            <asp:ListItem>KARS</asp:ListItem>
                            <asp:ListItem>MARS</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="background-color: #FFFFFF" class="style28">
                    </td>
            <td style="background-color: #FFFFFF" class="style28">
                    &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8" style="text-align: left" bgcolor="White">
                        &nbsp;</td>
                    <td class="auto-style4" style="text-align: left" bgcolor="White">
                        <asp:Calendar ID="Calendar1" runat="server" Height="113px" Width="271px">
                        </asp:Calendar>
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                        <br />
                        <br />
                    </td>
                    <td class="style14">
                        &nbsp;</td>
                    <td class="style14">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        &nbsp;</td>
                    <td class="auto-style1">
                        <asp:Button ID="sfrlistele" runat="server" Text="Seferleri Listele" CssClass="btn" onclick="sfrlistele_Click" />
                        </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        &nbsp;</td>
                    <td class="auto-style1">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                
            </table>
</p>
    
    </body>
</html>

    
    
    
    
    
    
    
    <br />
    <br />
    <br />
    Bu sayfa onlie satış sayfasıdır.<br />
    
&nbsp;
</asp:Content>
