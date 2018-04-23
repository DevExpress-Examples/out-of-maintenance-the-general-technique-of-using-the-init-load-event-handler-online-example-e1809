using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web;

public partial class Example2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void cb_Init(object sender, EventArgs e)
    {
        ASPxComboBox cb = sender as ASPxComboBox;
        GridViewDataItemTemplateContainer container = cb.NamingContainer as GridViewDataItemTemplateContainer;

        cb.ClientInstanceName = String.Format("cb{0}", container.VisibleIndex);
        cb.ClientSideEvents.SelectedIndexChanged =
            String.Format("function (s, e) {{ OnSelectedIndexChanged(s, e, txt{0}); }}",
            container.VisibleIndex);

        // Add some data
        cb.ValueType = typeof(System.Int32);
        cb.Items.Add("Text1", 1);
        cb.Items.Add("Text2", 2);
        cb.Items.Add("Text3", 3);
        cb.Items.Add("Text4", 4);
        cb.Items.Add("Text5", 5);
    }
    protected void txt_Init(object sender, EventArgs e)
    {
        ASPxTextBox txt = sender as ASPxTextBox;
        GridViewDataItemTemplateContainer container = txt.NamingContainer as GridViewDataItemTemplateContainer;

        txt.ClientInstanceName = String.Format("txt{0}", container.VisibleIndex);       
    }
}
