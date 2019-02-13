<%@ Register TagPrefix="uc1" TagName="ContactEditor" Src="ContactEditor.ascx" %>
<%@ Page language="c#" CodeFile="Contacts.aspx.cs" AutoEventWireup="false" Inherits="Contacts" %>
<%@ Register TagPrefix="user" TagName="ContactViewer" Src="ContactViewer.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Contacts</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P align="center"><asp:dropdownlist id="ContactList" runat="server" AutoPostBack="True" Width="70%"></asp:dropdownlist>&nbsp;<asp:button id="ButtonShow" runat="server" Text="Mostrar"></asp:button>
				<asp:button id="ButtonCreate" runat="server" Text="Nuevo..."></asp:button></P>
			<DIV align="center">
				<P id="Header" style="FONT-SIZE: larger; WIDTH: 90%; COLOR: white; BACKGROUND-COLOR: gray"
					align="center" runat="server">Información de contacto de
					<asp:label id="LabelContact" runat="server" ForeColor="Yellow">...</asp:label></P>
			</DIV>
			<P align="center"><user:contactviewer id="ContactView" runat="server" Visible="False"></user:contactviewer>
				<uc1:ContactEditor id="ContactEdit" runat="server" Visible="False"></uc1:ContactEditor></P>
			<P align="center">
				<asp:button id="ButtonSave" runat="server" Text="Guardar" Visible="False"></asp:button>
				&nbsp;&nbsp;&nbsp;
				<asp:button id="ButtonEdit" runat="server" Text="Editar" Visible="False"></asp:button>
				<asp:button id="ButtonDelete" runat="server" Text="Eliminar" Visible="False"></asp:button>
				&nbsp;&nbsp;&nbsp;
				<asp:button id="ButtonCancel" runat="server" Text="Cancelar" Visible="False"></asp:button></P>
		</form>
	</body>
</HTML>
