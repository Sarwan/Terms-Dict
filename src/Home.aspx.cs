using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (!String.IsNullOrEmpty(Request.QueryString["q"]))
            {
                string q = Request.QueryString["q"];
                string l = Request.QueryString["l"];
                //getTerms(q, getLangCode(l));
                getTerms(q, Convert.ToInt16(l));
            }
        }
    }

    private void getTerms(string q, int p)
    {
        TermsDataContextDataContext dcTerms = new TermsDataContextDataContext();
        var trms = from t in dcTerms.TermWithCategories
                   where t.English == q || t.Chinese == q || t.Uyghur == q
                   select t;
        StringBuilder sb = new StringBuilder();
        foreach (var trm in trms)
        {
            sb.Append("<h4 class=\"keyword\">").Append(trm.Uyghur.Trim()).Append("<span class=\"TermCat\"> (").Append(trm.CategoryChinese).Append(")</span>").Append("</h4>").AppendLine();

            sb.AppendLine("<p class=\"Translation\">");
            if (!string.IsNullOrEmpty(trm.English) && trm.English.Trim().Length>0)
            {
                sb.Append("<span>").Append(trm.English.Trim()).Append("</span>").AppendLine();
                sb.AppendLine("<br/>");
            }
            if (!string.IsNullOrEmpty(trm.Chinese) && trm.Chinese.Trim().Length > 0)
            {
                sb.Append("<span>").Append(trm.Chinese).Append("</span>").AppendLine();
            }
            sb.AppendLine("</p>");
        }

        ltrlResult.Text = sb.ToString();
    }



    private int getLangCode(string strLangName)
    {
        if (strLangName == "Uyghur")
        {
            return 1;
        }
        else if (strLangName == "English")
        {
            return 2;
        }
        else if (strLangName == "Chinese")
        {
            return 3;
        }
        else
        {
            return 0;
        }
    }

    
}