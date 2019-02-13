<%@ Control Language="c#" AutoEventWireup="true" CodeFile="ContactEditor.ascx.cs" Inherits="ContactEditor" %>
<DIV align="center">
	<TABLE id="Table1" cellSpacing="2" cellPadding="2" width="90%" align="center" border="0">
		<TR>
			<TD width="100" bgColor="#cccccc"><STRONG>Nombre</STRONG></TD>
			<TD bgColor="#e0e0e0">
				<asp:TextBox id="TextBoxName" runat="server" Width="100%"></asp:TextBox></TD>
			<TD vAlign="middle" align="center" width="20%" rowSpan="6" bgColor="#e0e0e0">
				<asp:Image id="ImagePhoto" runat="server" Height="200px" ImageUrl="contacts/image/sherlock.gif"></asp:Image></TD>
		</TR>
		<TR>
			<TD bgColor="#cccccc"><STRONG>E-mail</STRONG></TD>
			<TD bgColor="#e0e0e0">
				<asp:TextBox id="TextBoxEMail" runat="server" Columns="30"></asp:TextBox></TD>
		</TR>
		<TR>
			<TD bgColor="#cccccc"><STRONG>Teléfono</STRONG></TD>
			<TD bgColor="#e0e0e0">
				<asp:TextBox id="TextBoxTelephone" runat="server" Columns="16"></asp:TextBox></TD>
		</TR>
		<TR>
			<TD bgColor="#cccccc"><STRONG>Móvil</STRONG></TD>
			<TD bgColor="#e0e0e0">
				<asp:TextBox id="TextBoxMobile" runat="server" Columns="16"></asp:TextBox></TD>
		</TR>
		<TR>
			<TD style="WIDTH: 103px" bgColor="#cccccc"><STRONG>Fax</STRONG></TD>
			<TD bgColor="#e0e0e0">
				<asp:TextBox id="TextBoxFax" runat="server" Columns="16"></asp:TextBox></TD>
		</TR>
		<TR>
			<TD bgColor="#cccccc" valign="top"><STRONG>Dirección</STRONG></TD>
			<TD bgColor="#e0e0e0">
				<asp:TextBox id="TextBoxAddress" runat="server" TextMode="MultiLine" Width="100%" Rows="3"></asp:TextBox></TD>
		</TR>
		<TR>
			<TD bgColor="#cccccc"><STRONG>Fotografía</STRONG></TD>
			<TD bgColor="#e0e0e0" colSpan="2">
				<P align="right"><INPUT id="FilePhoto" type="file" size="40" name="FilePhoto" runat="server"></P>
			</TD>
		</TR>
		<TR>
			<TD bgColor="#cccccc" valign="top"><STRONG>Comentarios</STRONG></TD>
			<TD bgColor="#e0e0e0" colSpan="2">
				<P>
					<asp:TextBox id="TextBoxComments" runat="server" Width="100%" Rows="7" TextMode="MultiLine"></asp:TextBox></P>
			</TD>
		</TR>
	</TABLE>
</DIV>
