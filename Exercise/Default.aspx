<%@ Page Title=".NET Tech Challenge" Language="C#" MasterPageFile="/Site.master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Exercise._Default" ViewStateMode="Disabled" ValidateRequest="false" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
	
    <%--Input Form with name and number field--%>
	<asp:PlaceHolder ID="WordNumberForm" runat="server">
		<h1>.NET Tech Challenge</h1>
		<p>Accepts Name and Number and converts Number into Words. Then displays both name and number in words.</p>

		<fieldset>
			<label for="NameTextBox"></label>
			<asp:TextBox ID="NameTextBox" runat="server" placeholder="Please enter your Name"></asp:TextBox>
			<asp:Label ID="ValidationErrorName" runat="server" Visible="true" CssClass="error"></asp:Label>

			<label for="NumberTextBox"></label>
			<asp:TextBox ID="NumberTextBox" runat="server" placeholder="Please enter Number"></asp:TextBox>
			<asp:Label ID="ValidationErrorNumber" runat="server" Visible="false" CssClass="error"></asp:Label>		

			<asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitDataAction" />
		</fieldset>

	</asp:PlaceHolder>

    <%--Dispay Success Message--%>
	<asp:PlaceHolder ID="SuccessMessage" runat="server" Visible="false">
		<h1>Result</h1>
		<p>
			<b>Name:</b><asp:Literal ID="Name" runat="server" /><br /><br />
			<b>Number in words:</b><asp:Literal ID="Number" runat="server" />
		</p>
        <asp:Label ID="ValidationSuccess" runat="server" Visible="false" CssClass="success"></asp:Label>
	</asp:PlaceHolder>

    <%--Dispay Error Message--%>
	<asp:PlaceHolder ID="ErrorMessage" runat="server" Visible="false">
		<p class="error">Something went wrong!! Please try again later.</p>
	</asp:PlaceHolder>

</asp:Content>
