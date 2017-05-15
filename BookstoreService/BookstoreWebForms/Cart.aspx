<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="BookstoreWebForms.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Моята количка</h1>
 
    <asp:Label ID="lblErrorDeleting" runat="server" Text="Грешка при опит за изтриване от количката" Visible="false"></asp:Label>
 
    <asp:GridView ID="gvCart" runat="server" AutoGenerateColumns="False" DataKeyNames="BookID" CssClass="table table-bordered table-striped" OnRowDeleting="gvCart_RowDeleting">
        <Columns>
            <asp:ImageField DataImageUrlField="BookID" DataImageUrlFormatString="~/Cover.ashx?id={0}" ControlStyle-Width="100" HeaderStyle-Width="100"></asp:ImageField>
            <asp:BoundField DataField="BookID" HeaderText="ID" SortExpression="BookID"></asp:BoundField>
            <asp:BoundField DataField="Book.Title" HeaderText="Title" SortExpression="Title"></asp:BoundField>
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity"></asp:BoundField>
            <asp:BoundField DataField="Book.Price" HeaderText="Price" SortExpression="Price"></asp:BoundField>
            <asp:ButtonField ButtonType="Button" Text="Премахни" CommandName="Delete" />
        </Columns>
    </asp:GridView>
 
    <asp:Panel runat="server" ID="pCartDOptions" CssClass="panel panel-default">
        <div class="panel-heading"><div class="panel-title">Начин на доставка:</div></div>
        <div class="panel-body">
            <asp:DropDownList ID="listDeliveryOptions" runat="server" DataSourceID="odsDeliveryOptions" DataTextField="Name" DataValueField="DeliveryOptionID"></asp:DropDownList>
            <asp:ObjectDataSource runat="server" ID="odsDeliveryOptions" SelectMethod="GetDeliveryOptions" TypeName="BookstoreWebForms.CartService.CartServiceClient"></asp:ObjectDataSource>
        </div>
    </asp:Panel>
 
    <asp:Panel runat="server" ID="pCartPMethods" CssClass="panel panel-default">
        <div class="panel-heading"><div class="panel-title">Начин на плащане:</div></div>
        <div class="panel-body">
            <asp:DropDownList ID="listPaymentMethods" runat="server" DataSourceID="odsPaymentMethods" DataTextField="Name" DataValueField="PaymentMethodID"></asp:DropDownList>
            <asp:ObjectDataSource runat="server" ID="odsPaymentMethods" SelectMethod="GetPaymentMethods" TypeName="BookstoreWebForms.CartService.CartServiceClient"></asp:ObjectDataSource>
        </div>
    </asp:Panel>
 
    <div class="row">
        <div class="pull-left sum">
            Сума: 
            <asp:Label ID="lblSum" runat="server" Text=""></asp:Label>
        </div>
        <div class="pull-right">
            <asp:Button ID="btnPurchase" runat="server" Text="Поръчай &raquo;" OnClick="btnPurchase_Click" CssClass="btn btn-primary btn-lg" />
        </div>
    </div>
</asp:Content>