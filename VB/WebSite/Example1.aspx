<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Example1.aspx.vb" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web" TagPrefix="dxwgv" %>
<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web" TagPrefix="dxe" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>Untitled Page</title>
</head>
<body>
	<form id="form1" runat="server">
		<div>
			<dxwgv:ASPxGridView ID="grid" runat="server" AutoGenerateColumns="False" DataSourceID="ads"
				KeyFieldName="CategoryID" OnRowUpdating="grid_RowUpdating" OnRowInserting="grid_RowInserting">
				<Columns>
                    <dxwgv:GridViewCommandColumn VisibleIndex="0" ShowEditButton="True" ShowNewButton="True"/>
					<dxwgv:GridViewDataTextColumn FieldName="CategoryID" ReadOnly="True" VisibleIndex="1">
						<EditFormSettings Visible="False" />
					</dxwgv:GridViewDataTextColumn>
					<dxwgv:GridViewDataTextColumn FieldName="CategoryName" VisibleIndex="2">
					</dxwgv:GridViewDataTextColumn>
					<dxwgv:GridViewDataTextColumn FieldName="Description" VisibleIndex="3">
					</dxwgv:GridViewDataTextColumn>
				</Columns>
				<Templates>
					<EditForm>
						<table>
							<tr>
								<td>
									Category Name:</td>
								<td>
									<dxe:ASPxTextBox ID="txtName" runat="server" Width="170px" OnInit="txtName_Init">
									</dxe:ASPxTextBox>
								</td>
							</tr>
							<tr>
								<td>
									Description:</td>
								<td>
									<dxe:ASPxTextBox ID="txtDesc" runat="server" Width="170px" OnLoad="txtDesc_Load">
									</dxe:ASPxTextBox>
								</td>
							</tr>
							<tr>
								<td colspan="2">
									<dxwgv:ASPxGridViewTemplateReplacement ID="update" runat="server" ReplacementType="EditFormUpdateButton">
									</dxwgv:ASPxGridViewTemplateReplacement>
									<dxwgv:ASPxGridViewTemplateReplacement ID="cancel" runat="server" ReplacementType="EditFormCancelButton">
									</dxwgv:ASPxGridViewTemplateReplacement>
								</td>
							</tr>
						</table>
					</EditForm>
				</Templates>
			</dxwgv:ASPxGridView>
			<asp:AccessDataSource ID="ads" runat="server" DataFile="~/App_Data/nwind.mdb" DeleteCommand="DELETE FROM [Categories] WHERE [CategoryID] = ?"
				InsertCommand="INSERT INTO [Categories] ([CategoryID], [CategoryName], [Description]) VALUES (?, ?, ?)"
				SelectCommand="SELECT [CategoryID], [CategoryName], [Description] FROM [Categories]"
				UpdateCommand="UPDATE [Categories] SET [CategoryName] = ?, [Description] = ? WHERE [CategoryID] = ?">
				<DeleteParameters>
					<asp:Parameter Name="CategoryID" Type="Int32" />
				</DeleteParameters>
				<UpdateParameters>
					<asp:Parameter Name="CategoryName" Type="String" />
					<asp:Parameter Name="Description" Type="String" />
					<asp:Parameter Name="CategoryID" Type="Int32" />
				</UpdateParameters>
				<InsertParameters>
					<asp:Parameter Name="CategoryID" Type="Int32" />
					<asp:Parameter Name="CategoryName" Type="String" />
					<asp:Parameter Name="Description" Type="String" />
				</InsertParameters>
			</asp:AccessDataSource>
		</div>
	</form>
</body>
</html>
