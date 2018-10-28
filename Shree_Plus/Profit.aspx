<%@ Page Title="" Language="C#" MasterPageFile="~/EPluesHeader.Master" AutoEventWireup="true" CodeBehind="Profit.aspx.cs" Inherits="Shree_Plus.Profit" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<h1 style="margin-left: 100px">Profit </h1>
	<hr />
	<div class="form-row" style="margin-left: 100px">
		<div class="form-group col-md-6">
			<label class="col-sm-2">From Date</label>
			<telerik:RadDateTimePicker ID="radFromDate" runat="server"></telerik:RadDateTimePicker>
		</div>
		<div class="form-group col-md-6">
			<label class="col-sm-2">To Date</label>
			<telerik:RadDateTimePicker ID="radToDate" runat="server"></telerik:RadDateTimePicker>
		</div>
	</div>
	<hr />
	<div class="form-row" style="margin-left: 100px">
		<div class="form-group col-md">
			<asp:Button ID="btnSubmit" runat="server" Text="Search" Width="100px" CssClass="btn btn-primary" OnClick="btnSubmit_Click" />
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
			<label class="col-sm-2">Total Expense</label>
			<asp:Label ID="lblExpense" runat="server" Text="00"></asp:Label>
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
	<hr />
	<div class="container-fluid">

		<div class="row">
			<div class="col-lg-6">
				<h4 align="center"> Purchase </h4>
				<telerik:RadGrid ID="grdPurchase" runat="server"></telerik:RadGrid>
			</div>
			<div class="col-lg-6">
				<h4 align="center"> Sells </h4>
				<telerik:RadGrid ID="grdSells" runat="server"></telerik:RadGrid>
			</div>
		</div>
		<div class="row">
			<div class="col-lg-6">
				<h4 align="center"> Expences </h4>
				<telerik:RadGrid ID="grdExpense" runat="server"></telerik:RadGrid>
			</div>
		</div>
	</div>
</asp:Content>
