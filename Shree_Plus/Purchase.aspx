<%@ Page Title="" Language="C#" MasterPageFile="~/EPluesHeader.Master" AutoEventWireup="true" CodeBehind="Purchase.aspx.cs" Inherits="Shree_Plus.Purchase" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<h1 style="margin-left: 100px"> Purchase </h1>
	<hr />
	<div class="form-row" style="margin-left: 100px">
		<div class="form-group col-md">
			<label  for="inlineFold" class="col-sm-2">Stock Amount</label>
			<span class="input-group  col-sm-5">
			<asp:TextBox ID="txtStockAmount" placeholder="Stock Amount" CssClass="form-control" runat="server"></asp:TextBox></span>
		</div>
	</div>
	<div class="form-row" style="margin-left: 100px">
		<div class="form-group col-md">
			<label class="col-sm-2">Purchase Date</label>
			<telerik:RadDateTimePicker ID="RadPurchaseDate" runat="server"></telerik:RadDateTimePicker>
		</div>
	</div>
	<hr />
	<div class="form-row" style="margin-left: 280px">
		<div class="form-group col-md col-sm-2">
			<asp:Button ID="btnSubmit" runat="server" Text="Submit" Width="100px" CssClass="btn btn-primary" OnClick="btnSubmit_Click" />
		</div>
	</div>
	<br />
	<hr />

	<telerik:RadGrid ID="grdPurchase" runat="server"></telerik:RadGrid>
</asp:Content>

