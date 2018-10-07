<%@ Page Title="" Language="C#" MasterPageFile="~/EPluesHeader.Master" AutoEventWireup="true" CodeBehind="Sells.aspx.cs" Inherits="Shree_Plus.Sells" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<h1 style="margin-left: 100px"> Sells </h1>
	<hr />
	<div class="form-row" style="margin-left: 100px">
		<div class="form-group col-md">
			<label class="col-sm-2">Sells Date</label>
			<telerik:RadDateTimePicker ID="RadSellDate" runat="server"></telerik:RadDateTimePicker>
		</div>
	</div>
	<div class="form-row" style="margin-left: 100px">
		<div class="form-group col-md">
			<label  for="inlineFold" class="col-sm-2">Details</label>
			<span class="input-group  col-sm-5">
				<textarea runat="server" id="txtDetails" class="form-control" placeholder="Stock Amount"></textarea></span>
		</div>
	</div>
	<div class="form-row" style="margin-left: 100px">
		<div class="form-group col-md">
			<label class="col-sm-2">Select Vehicle</label>
			<asp:DropDownList ID="ddlVehicle" runat="server"></asp:DropDownList>
		</div>
	</div>
	<div class="form-row" style="margin-left: 100px">
		<div class="form-group col-md">
			<label  for="inlineFold" class="col-sm-2">Sell Amount</label>
			<span class="input-group  col-sm-5">
			<asp:TextBox ID="txtSellAmount" placeholder="Sell Amount" CssClass="form-control" runat="server"></asp:TextBox></span>
		</div>
	</div>
	<div class="form-row" style="margin-left: 100px">
		<div class="form-group col-md">
			<label class="col-sm-2">WareHouse</label>
			<asp:DropDownList ID="ddlWareHourse" runat="server"></asp:DropDownList>
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

	<telerik:RadGrid ID="grdSells" runat="server"></telerik:RadGrid>
</asp:Content>
