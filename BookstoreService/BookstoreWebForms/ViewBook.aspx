<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewBook.aspx.cs" Inherits="BookstoreWebForms.ViewBook" %>
 
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="FormView1" runat="server" DataSourceID="booksDataSource">
        <ItemTemplate>
            <div class="col-md-3">
                <asp:Image runat="server" ID="Cover" ImageUrl='<%# "~/Cover.ashx?id=" + Eval("BookID") %>' Width="100%" />
            </div>
            <div class="col-md-9">
                <h1>
                    <asp:Label Text='<%# Bind("Title") %>' runat="server" ID="TitleLabel" /></h1>
 
                <div class="description">
                    <asp:Label Text='<%# Bind("Description") %>' runat="server" ID="DescriptionLabel" /><br />
                </div>
 
                <p>Year:
                    <asp:Label Text='<%# Bind("Year") %>' runat="server" ID="YearLabel" /></p>
 
                <p>ISBN:
                    <asp:Label Text='<%# Bind("ISBN") %>' runat="server" ID="ISBNLabel" /></p>
 
                <h3>Price:
                    <asp:Label Text='<%# Bind("Price") %>' runat="server" ID="PriceLabel" /></h3>
 
                <asp:Button runat="server" ID="BuyButton" Text="Добави" OnClick="BuyButton_Click" CssClass="btn btn-lg btn-success"></asp:Button>
            </div>
        </ItemTemplate>
    </asp:FormView>
 
    <div class="row">
        <a href="javascript:history.go(-1);" class="btn btn-default pull-right"><i class="glyphicon glyphicon-arrow-left"></i> Назад</a>
    </div>
 
    <asp:ObjectDataSource runat="server" ID="booksDataSource" SelectMethod="GetBook" TypeName="BookstoreWebForms.BookstoreService.BooksServiceClient">
        <SelectParameters>
            <asp:QueryStringParameter QueryStringField="id" Type="Int32" ConvertEmptyStringToNull="true" Name="id" />
        </SelectParameters>
    </asp:ObjectDataSource>

    <h3>Подобни книги от Google Books:</h3>
 
    <asp:GridView ID="GridView1" runat="server" DataSourceID="similarDataSource" AutoGenerateColumns="False" CssClass="table table-bordered table-condensed">
        <Columns>
            <asp:BoundField DataField="ISBN" HeaderText="ISBN" SortExpression="ISBN"></asp:BoundField>
            <asp:HyperLinkField DataTextField="Title" DataTextFormatString="{0}" DataNavigateUrlFields="Link" DataNavigateUrlFormatString="{0}"
                 HeaderText="Title" SortExpression="Title" Target="_blank"></asp:HyperLinkField>
            <asp:BoundField DataField="Publisher" HeaderText="Publisher" SortExpression="Publisher"></asp:BoundField>
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource runat="server" ID="similarDataSource" SelectMethod="GetSimilarBooks" TypeName="BookstoreWebForms.BookstoreService.BooksServiceClient">
        <SelectParameters>
            <asp:QueryStringParameter QueryStringField="id" Name="id" Type="Int32"></asp:QueryStringParameter>
        </SelectParameters>
    </asp:ObjectDataSource>
    </asp:Content>