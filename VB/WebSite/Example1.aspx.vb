Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web.ASPxEditors
Imports DevExpress.Web.ASPxGridView

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Private txtName As ASPxTextBox
	Private txtDesc As ASPxTextBox

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

	End Sub
	Protected Sub txtName_Init(ByVal sender As Object, ByVal e As EventArgs)
		txtName = CType(sender, ASPxTextBox)
		Dim container As GridViewEditFormTemplateContainer = TryCast(txtName.NamingContainer, GridViewEditFormTemplateContainer)

		' You can remove the if statement, and try to insert a new record. You'll catch an exception, because the DataBinder returns null reference
		If (Not container.Grid.IsNewRowEditing) Then
			txtName.Text = DataBinder.Eval(container.DataItem, "CategoryName").ToString()
		End If
	End Sub
	Protected Sub txtDesc_Load(ByVal sender As Object, ByVal e As EventArgs)
		txtDesc = CType(sender, ASPxTextBox)
		Dim container As GridViewEditFormTemplateContainer = TryCast(txtDesc.NamingContainer, GridViewEditFormTemplateContainer)

		' You can remove the if statement, and try to insert a new record. You'll catch an exception, because the DataBinder returns null reference
		If (Not container.Grid.IsNewRowEditing) Then
			txtDesc.Text = DataBinder.Eval(container.DataItem, "Description").ToString()
		End If
	End Sub

	Protected Sub grid_RowUpdating(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataUpdatingEventArgs)
		e.NewValues("CategoryName") = txtName.Text
		e.NewValues("Description") = txtDesc.Text

		Throw New Exception("You can't change online database")
	End Sub
	Protected Sub grid_RowInserting(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataInsertingEventArgs)
		Throw New Exception("You can't change online database")
	End Sub
End Class
