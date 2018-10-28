<%@ Page Title="" Language="C#" MasterPageFile="~/EPluesHeader.Master" AutoEventWireup="true" CodeBehind="ReportSection.aspx.cs" Inherits="Shree_Plus.ReportSection" %>

<%@ Register Assembly="Telerik.ReportViewer.Html5.WebForms, Version=12.2.18.912, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" Namespace="Telerik.ReportViewer.Html5.WebForms" TagPrefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<telerik:ReportViewer ID="ReportViewer1" runat="server"></telerik:ReportViewer>
</asp:Content>
