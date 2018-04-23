Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web.ASPxEditors
Imports DevExpress.Web.ASPxGridView

Partial Public Class Example2
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

	End Sub
	Protected Sub cb_Init(ByVal sender As Object, ByVal e As EventArgs)
		Dim cb As ASPxComboBox = TryCast(sender, ASPxComboBox)
		Dim container As GridViewDataItemTemplateContainer = TryCast(cb.NamingContainer, GridViewDataItemTemplateContainer)

		cb.ClientInstanceName = String.Format("cb{0}", container.VisibleIndex)
		cb.ClientSideEvents.SelectedIndexChanged = String.Format("function (s, e) {{ OnSelectedIndexChanged(s, e, txt{0}); }}", container.VisibleIndex)

		' Add some data
		cb.ValueType = GetType(System.Int32)
		cb.Items.Add("Text1", 1)
		cb.Items.Add("Text2", 2)
		cb.Items.Add("Text3", 3)
		cb.Items.Add("Text4", 4)
		cb.Items.Add("Text5", 5)
	End Sub
	Protected Sub txt_Init(ByVal sender As Object, ByVal e As EventArgs)
		Dim txt As ASPxTextBox = TryCast(sender, ASPxTextBox)
		Dim container As GridViewDataItemTemplateContainer = TryCast(txt.NamingContainer, GridViewDataItemTemplateContainer)

		txt.ClientInstanceName = String.Format("txt{0}", container.VisibleIndex)
	End Sub
End Class
