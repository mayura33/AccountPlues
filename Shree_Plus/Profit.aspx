<%@ Page Title="" Language="C#" MasterPageFile="~/EPluesHeader.Master" AutoEventWireup="true" CodeBehind="Profit.aspx.cs" Inherits="Shree_Plus.Profit" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<h1 style="margin-left: 100px">Profit </h1>
	<hr />
	<div class="form-row" style="margin-left: 100px">
		<div class="form-group col-md-6">
			<label class="col-sm-2">From Date</label>
			<telerik:RadDateTimePicker ID="fromDate" runat="server"></telerik:RadDateTimePicker>
		</div>
		<div class="form-group col-md-6">
			<label class="col-sm-2">To Date</label>
			<telerik:RadDateTimePicker ID="toDate" runat="server"></telerik:RadDateTimePicker>
		</div>
	</div>
	<hr />
	<div class="form-row" style="margin-left: 100px">
		<div class="form-group col-md">
			<asp:Button ID="btnSubmit" runat="server" Text="Submit" Width="100px" CssClass="btn btn-primary" OnClick="btnSubmit_Click"/>
		</div>
	</div>
	<div class="form-row" style="margin-left: 100px">
		<div class="form-group col-md">
			<label class="col-sm-2">Total Purchase</label>
			<asp:Label ID="lblTotalPurchase" runat="server" Text="00"></asp:Label>
		</div>
	</div>
	<div class="form-row" style="margin-left: 100px">
		<div class="form-group col-md">
			<label class="col-sm-2">Total Sells</label>
			<asp:Label ID="lblSells" runat="server" Text="00"></asp:Label>
		</div>
	</div>
	<div class="form-row" style="margin-left: 100px">
		<div class="form-group col-md">
			<label class="col-sm-2">Total Profit</label>
			<asp:Label ID="lblTotalProfit" runat="server" Text="00"></asp:Label>
		</div>
	</div>
	<div class="form-row" style="margin-left: 100px">
		<div class="form-group col-md">
		</div>
	</div>

	<br />
	<hr />
</asp:Content>
