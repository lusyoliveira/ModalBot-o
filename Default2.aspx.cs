﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSim_Click(object sender, EventArgs e)
    {
        Response.Redirect(String.Format("Default.aspx?link={0}", ((Button)sender).Text)); 
         }
    protected void btnNao_Click(object sender, EventArgs e)
    {
        Response.Redirect(String.Format("Default.aspx?link={0}", ((Button)sender).Text)); 
    }
}