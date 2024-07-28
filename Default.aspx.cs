using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["link"] != null)
        {
            Label1.Text = String.Format("Você clicou em : {0}", Request.QueryString["link"].ToString());
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string script = "tb_show('','Default2.aspx?height=85&width=120','');"; ScriptManager.RegisterClientScriptBlock(UpdatePanel1, this.GetType(), "janela", script, true);  
    }
}