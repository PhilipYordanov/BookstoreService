<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="CartPay.aspx.cs" Inherits="BookstoreWebForms.CartPay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  <h1>плащане</h1>



    
        <input type="hidden" name="PAGE" value="credit_paydirect"/>
        <input type="hidden" ID="hEncoded" name="ENCODED" value="<%= _encoded %>" />
        <input type="hidden" ID="hChecksum" name="CHECKSUM" value="<%= _checksum %>" />
        <asp:Button id="btnEPay" runat="server" Text="Плащане с ePay.bg" PostBackUrl="https://demo.epay.bg/" CssClass="btn btn-lg btn-primary">
        </asp:Button>
    </asp:Content>
