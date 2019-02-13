<%@ Control Language="c#" AutoEventWireup="true" CodeFile="ContactViewer.ascx.cs" Inherits="ContactViewer"%>
<DIV align="center">
	<TABLE id="Table1" cellSpacing="2" cellPadding="2" width="90%" align="center" border="0">
		<TR>
			<TD width="100" bgColor="#cccccc"><STRONG>Nombre</STRONG></TD>
			<TD bgColor="#e0e0e0">
				<asp:Label id="LabelName" runat="server">Nombre del contacto</asp:Label></TD>
			<TD vAlign="middle" align="center" width="20%" rowSpan="6" bgColor="#e0e0e0">
				<asp:Image id="ImagePhoto" runat="server" Height="200px" ImageUrl="contacts/image/sherlock.gif"></asp:Image></TD>
		</TR>
		<TR>
			<TD bgColor="#cccccc"><STRONG>E-mail</STRONG></TD>
			<TD bgColor="#e0e0e0">
				<asp:HyperLink id="LinkEMail" runat="server">mailbox@domain</asp:HyperLink></TD>
		</TR>
		<TR>
			<TD bgColor="#cccccc"><STRONG>Teléfono</STRONG></TD>
			<TD bgColor="#e0e0e0">
				<asp:Label id="LabelTelephone" runat="server">999 999 999</asp:Label></TD>
		</TR>
		<TR>
			<TD bgColor="#cccccc"><STRONG>Móvil</STRONG></TD>
			<TD bgColor="#e0e0e0">
				<asp:Label id="LabelMobile" runat="server">999 999 999</asp:Label></TD>
		</TR>
		<TR>
			<TD style="WIDTH: 103px" bgColor="#cccccc"><STRONG>Fax</STRONG></TD>
			<TD bgColor="#e0e0e0">
				<asp:Label id="LabelFax" runat="server">999 999 999</asp:Label></TD>
		</TR>
		<TR>
			<TD bgColor="#cccccc" vAlign="top"><STRONG>Dirección</STRONG></TD>
			<TD bgColor="#e0e0e0" vAlign="top">
				<asp:Label id="LabelAddress" runat="server">Calle<BR>Localidad CP Provincia</asp:Label></TD>
		</TR>
		<TR>
			<TD vAlign="top" bgColor="#cccccc"><STRONG>Comentarios</STRONG></TD>
			<TD vAlign="top" bgColor="#e0e0e0" colSpan="2">
				<asp:Label id="LabelComments" runat="server">Comentarios<BR>...</asp:Label></TD>
		</TR>
	</TABLE>
</DIV>
