using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Common_Main : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (!Page.IsPostBack)
            {
                if (!String.IsNullOrEmpty(Request.QueryString["q"]))
                {
                    string q = Request.QueryString["q"];
                    string l = Request.QueryString["l"];
                    txtKeyWord.Text = q;
                    ddlLanguage.SelectedIndex = Convert.ToInt16(l) - 1;
                }
            }
        }
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        string strUrl = "~/Home.aspx?q="+txtKeyWord.Text.Trim()+"&l="+ddlLanguage.SelectedValue;
        Response.Redirect(strUrl);
    }
}
