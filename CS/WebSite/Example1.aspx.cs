using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web;

public partial class _Default : System.Web.UI.Page
{
    ASPxTextBox txtName;
    ASPxTextBox txtDesc;

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void txtName_Init(object sender, EventArgs e)
    {
        txtName = (ASPxTextBox)sender;
        GridViewEditFormTemplateContainer container = txtName.NamingContainer as GridViewEditFormTemplateContainer;

        // You can remove the if statement, and try to insert a new record. You'll catch an exception, because the DataBinder returns null reference
        if (!container.Grid.IsNewRowEditing)
            txtName.Text = DataBinder.Eval(container.DataItem, "CategoryName").ToString();
    }
    protected void txtDesc_Load(object sender, EventArgs e)
    {
        txtDesc = (ASPxTextBox)sender;
        GridViewEditFormTemplateContainer container = txtDesc.NamingContainer as GridViewEditFormTemplateContainer;

        // You can remove the if statement, and try to insert a new record. You'll catch an exception, because the DataBinder returns null reference
        if (!container.Grid.IsNewRowEditing)
            txtDesc.Text = DataBinder.Eval(container.DataItem, "Description").ToString();
    }

    protected void grid_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
    {
        e.NewValues["CategoryName"] = txtName.Text;
        e.NewValues["Description"] = txtDesc.Text;

        throw new Exception("You can't change online database");
    }
    protected void grid_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
    {
        throw new Exception("You can't change online database");
    }
}
