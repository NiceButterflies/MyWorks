<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MobileWebFormsApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <h3>Interview</h3>
        <h4>
    <asp:Label ID="Label1" runat="server" Text="1) Ваш пол" />

    <asp:DropDownList ID="Sex" runat="server">
        <asp:ListItem Text="Ж" />
        <asp:ListItem Text="М" />
    </asp:DropDownList>
    <asp:Label ID="Label2" runat="server" Text="&nbsp&nbsp&nbsp&nbsp2) Ваш возраст" />
    <asp:TextBox ID="Age" runat="server"></asp:TextBox>
    <br /><br />
    <asp:Label ID="Label3" runat="server" Text="3) Род занятий" /></h4>
    <asp:RadioButtonList ID="Profession" runat="server">
        <asp:ListItem Text="&nbspруководитель" />
        <asp:ListItem Text="&nbspспециалист/служащий" />
        <asp:ListItem Text="&nbspрабочий" />
        <asp:ListItem Text="&nbspстудент/учащийся" />
        <asp:ListItem Text="&nbspпенсионер" />
        <asp:ListItem Text="&nbspбезработный/временно не работающий" />
        <asp:ListItem Text="&nbspдругое" />
    </asp:RadioButtonList>
        <br /><h4>
    <asp:Label ID="Label4" runat="server" Text="4) Ваш среднемесячный доход" />
    <asp:TextBox ID="Income" runat="server"></asp:TextBox> у.е.
    <br /><br />
       <asp:Label ID="Label5" runat="server" Text="5) Являетесь ли вы обладателем телефона?" /></h4>
    <asp:RadioButtonList ID="MobileExistence" runat="server">
        <asp:ListItem Text="&nbspда"/>
        <asp:ListItem Text="&nbspнет"/>
    </asp:RadioButtonList>
    <br /><h4>
    <asp:Label ID="Label6" runat="server" Text="6) Если да, то каким телефоном вы пользуетесь?" />
            </h4>
    <asp:DropDownList ID="Brand" runat="server">
        <asp:ListItem Text="Nokia"/>
        <asp:ListItem Text="Samsung"/>
        <asp:ListItem Text="IPhone"/>
        <asp:ListItem Text="HTC"/>
        <asp:ListItem Text="SonyEricsone"/>
        <asp:ListItem Text="другой"/>
    </asp:DropDownList>
    <br />
    <br />
    <h4>
    <asp:Label ID="Label7" runat="server" Text="7) Сколько вы готовы потратить на новый телефон?" />
    <asp:TextBox ID="Price" runat="server"></asp:TextBox> у.е.
    <br />
    <br />
    <asp:Label ID="Label8" runat="server" Text="8) Какой операционной системе вы отдаете предпочтение?" /></h4>
    <asp:RadioButtonList ID="OS" runat="server">
        <asp:ListItem Text="&nbspAndroid" />
        <asp:ListItem Text="&nbspiOS" />
        <asp:ListItem Text="&nbspWindowsPhone" />
        <asp:ListItem Text="&nbspдругой" /></asp:RadioButtonList>
    <br /><h4>
    <asp:Label ID="Label9" runat="server" Text="9) При выборе телефона обращаете ли вы внимание на наличие" /><br />
    <asp:Label ID="Label11" runat="server" Text="сопутствующих товаров(гарнитура, чехлы и пр.) и цены на них?" /></h4>
    <asp:RadioButtonList ID="Furniture" runat="server">
        <asp:ListItem Text="&nbspда"/>
        <asp:ListItem Text="&nbspнет"/>
    </asp:RadioButtonList>
    <br /><h4>
    <asp:Label ID="Label10" runat="server" Text="10) Используете ли вы телефон для чтения электронных книг?" /></h4>
    <asp:RadioButtonList ID="Read" runat="server">
        <asp:ListItem Text="&nbspда"/>
        <asp:ListItem Text="&nbspнет"/>
    </asp:RadioButtonList>
    <br />
    <asp:Button class="btn" ID="Button1" runat="server" Text="Отправить" href="~/About" OnClick="Button1_Click" />
    <br />
    <br />

</asp:Content>
